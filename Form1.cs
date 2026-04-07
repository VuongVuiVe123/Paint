using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

namespace PaintApp
{
    public partial class Form1 : Form
    {
        // ============================================================
        //  DRAW OBJECTS (Polymorphism + Composite Pattern)
        // ============================================================
        public abstract class clsDrawObject
        {
            public Point p1;
            public Point p2;
            public Pen myPen = new Pen(Color.Blue, 2);
            public Brush myBrush = new SolidBrush(Color.Blue);
            public bool isSelected = false;

            public abstract void Draw(Graphics g);
            public abstract bool HitTest(Point p);
            public abstract Rectangle GetBoundingBox();

            public virtual void Move(int dx, int dy)
            {
                p1.X += dx; p1.Y += dy;
                p2.X += dx; p2.Y += dy;
            }

            protected Rectangle GetRect()
            {
                return new Rectangle(
                    Math.Min(p1.X, p2.X),
                    Math.Min(p1.Y, p2.Y),
                    Math.Abs(p2.X - p1.X),
                    Math.Abs(p2.Y - p1.Y));
            }

            protected void DrawSelectionHandles(Graphics g)
            {
                if (!isSelected) return;
                Rectangle r = GetBoundingBox();
                using (Pen selPen = new Pen(Color.Blue, 1) { DashStyle = DashStyle.Dash })
                    g.DrawRectangle(selPen, r);

                int sz = 6;
                SolidBrush hb = new SolidBrush(Color.White);
                Pen hp = new Pen(Color.Blue, 1);
                Point[] handles = GetHandlePoints();
                foreach (var h in handles)
                    g.FillRectangle(hb, h.X - sz / 2, h.Y - sz / 2, sz, sz);
                foreach (var h in handles)
                    g.DrawRectangle(hp, h.X - sz / 2, h.Y - sz / 2, sz, sz);
                hb.Dispose(); hp.Dispose();
            }

            public Point[] GetHandlePoints()
            {
                Rectangle r = GetBoundingBox();
                return new Point[]
                {
                    new Point(r.Left, r.Top),
                    new Point(r.Right, r.Top),
                    new Point(r.Left, r.Bottom),
                    new Point(r.Right, r.Bottom)
                };
            }

            // ---- Serialization helpers ----
            public string PenColorHex => ColorToHex(myPen.Color);
            public float PenWidth => myPen.Width;
            public int PenDash => (int)myPen.DashStyle;
            public string BrushColorHex => myBrush is SolidBrush sb ? ColorToHex(sb.Color)
                                         : myBrush is HatchBrush hb ? ColorToHex(hb.ForegroundColor) : "#0000FF";
            public int BrushHatchStyle => myBrush is HatchBrush hb2 ? (int)hb2.HatchStyle : -1;

            public static string ColorToHex(Color c) => $"#{c.R:X2}{c.G:X2}{c.B:X2}";
            public static Color HexToColor(string hex)
            {
                hex = hex.TrimStart('#');
                return Color.FromArgb(
                    Convert.ToInt32(hex.Substring(0, 2), 16),
                    Convert.ToInt32(hex.Substring(2, 2), 16),
                    Convert.ToInt32(hex.Substring(4, 2), 16));
            }

            public void ApplySerializedPen(string colorHex, float width, int dash)
            {
                myPen = new Pen(HexToColor(colorHex), width) { DashStyle = (DashStyle)dash };
            }
            public void ApplySerializedBrush(string colorHex, int hatchStyle)
            {
                Color c = HexToColor(colorHex);
                myBrush = hatchStyle < 0
                    ? (Brush)new SolidBrush(c)
                    : new HatchBrush((HatchStyle)hatchStyle, c, Color.Transparent);
            }
        }

        public class clsLine : clsDrawObject
        {
            public override void Draw(Graphics g)
            {
                g.DrawLine(myPen, p1, p2);
                DrawSelectionHandles(g);
            }
            public override bool HitTest(Point p)
            {
                double d = DistanceToLine(p1, p2, p);
                return d < 5;
            }
            public override Rectangle GetBoundingBox()
            {
                return new Rectangle(
                    Math.Min(p1.X, p2.X) - 5, Math.Min(p1.Y, p2.Y) - 5,
                    Math.Abs(p2.X - p1.X) + 10, Math.Abs(p2.Y - p1.Y) + 10);
            }
            private double DistanceToLine(Point a, Point b, Point p)
            {
                double len2 = (b.X - a.X) * (b.X - a.X) + (b.Y - a.Y) * (b.Y - a.Y);
                if (len2 == 0) return Math.Sqrt((p.X - a.X) * (p.X - a.X) + (p.Y - a.Y) * (p.Y - a.Y));
                double t = ((p.X - a.X) * (b.X - a.X) + (p.Y - a.Y) * (b.Y - a.Y)) / len2;
                t = Math.Max(0, Math.Min(1, t));
                double cx = a.X + t * (b.X - a.X);
                double cy = a.Y + t * (b.Y - a.Y);
                return Math.Sqrt((p.X - cx) * (p.X - cx) + (p.Y - cy) * (p.Y - cy));
            }
        }

        public class clsEllipse : clsDrawObject
        {
            public override void Draw(Graphics g)
            {
                Rectangle r = GetRect();
                if (r.Width < 1 || r.Height < 1) return;
                g.DrawEllipse(myPen, r);
                DrawSelectionHandles(g);
            }
            public override bool HitTest(Point p) { return GetBoundingBox().Contains(p); }
            public override Rectangle GetBoundingBox() { return GetRect(); }
        }

        public class clsFilledEllipse : clsDrawObject
        {
            public override void Draw(Graphics g)
            {
                Rectangle r = GetRect();
                if (r.Width < 1 || r.Height < 1) return;
                g.FillEllipse(myBrush, r);
                g.DrawEllipse(myPen, r);
                DrawSelectionHandles(g);
            }
            public override bool HitTest(Point p) { return GetBoundingBox().Contains(p); }
            public override Rectangle GetBoundingBox() { return GetRect(); }
        }

        public class clsRectangle : clsDrawObject
        {
            public override void Draw(Graphics g)
            {
                Rectangle r = GetRect();
                if (r.Width < 1 || r.Height < 1) return;
                g.DrawRectangle(myPen, r);
                DrawSelectionHandles(g);
            }
            public override bool HitTest(Point p) { return GetBoundingBox().Contains(p); }
            public override Rectangle GetBoundingBox() { return GetRect(); }
        }

        public class clsFilledRectangle : clsDrawObject
        {
            public override void Draw(Graphics g)
            {
                Rectangle r = GetRect();
                if (r.Width < 1 || r.Height < 1) return;
                g.FillRectangle(myBrush, r);
                g.DrawRectangle(myPen, r);
                DrawSelectionHandles(g);
            }
            public override bool HitTest(Point p) { return GetBoundingBox().Contains(p); }
            public override Rectangle GetBoundingBox() { return GetRect(); }
        }

        public class clsCircle : clsDrawObject
        {
            public override void Draw(Graphics g)
            {
                int sz = Math.Min(Math.Abs(p2.X - p1.X), Math.Abs(p2.Y - p1.Y));
                Rectangle r = new Rectangle(p1.X, p1.Y, sz, sz);
                g.DrawEllipse(myPen, r);
                DrawSelectionHandles(g);
            }
            public override bool HitTest(Point p) { return GetBoundingBox().Contains(p); }
            public override Rectangle GetBoundingBox()
            {
                int sz = Math.Min(Math.Abs(p2.X - p1.X), Math.Abs(p2.Y - p1.Y));
                return new Rectangle(p1.X, p1.Y, sz, sz);
            }
        }

        public class clsFilledCircle : clsDrawObject
        {
            public override void Draw(Graphics g)
            {
                int sz = Math.Min(Math.Abs(p2.X - p1.X), Math.Abs(p2.Y - p1.Y));
                Rectangle r = new Rectangle(p1.X, p1.Y, sz, sz);
                g.FillEllipse(myBrush, r);
                g.DrawEllipse(myPen, r);
                DrawSelectionHandles(g);
            }
            public override bool HitTest(Point p) { return GetBoundingBox().Contains(p); }
            public override Rectangle GetBoundingBox()
            {
                int sz = Math.Min(Math.Abs(p2.X - p1.X), Math.Abs(p2.Y - p1.Y));
                return new Rectangle(p1.X, p1.Y, sz, sz);
            }
        }

        public class clsArc : clsDrawObject
        {
            public float startAngle = 0f;
            public float sweepAngle = 180f;
            public override void Draw(Graphics g)
            {
                Rectangle r = GetRect();
                if (r.Width < 1 || r.Height < 1) return;
                g.DrawArc(myPen, r, startAngle, sweepAngle);
                DrawSelectionHandles(g);
            }
            public override bool HitTest(Point p) { return GetBoundingBox().Contains(p); }
            public override Rectangle GetBoundingBox() { return GetRect(); }
        }

        // Composite Pattern - Group
        public class clsGroup : clsDrawObject
        {
            public List<clsDrawObject> children = new List<clsDrawObject>();

            public override void Draw(Graphics g)
            {
                foreach (var obj in children)
                    obj.Draw(g);
                DrawSelectionHandles(g);
            }
            public override bool HitTest(Point p)
            {
                foreach (var obj in children)
                    if (obj.HitTest(p)) return true;
                return false;
            }
            public override Rectangle GetBoundingBox()
            {
                if (children.Count == 0) return Rectangle.Empty;
                Rectangle r = children[0].GetBoundingBox();
                for (int i = 1; i < children.Count; i++)
                    r = Rectangle.Union(r, children[i].GetBoundingBox());
                return r;
            }
            public override void Move(int dx, int dy)
            {
                foreach (var obj in children)
                    obj.Move(dx, dy);
            }
        }

        // ============================================================
        //  FORM FIELDS
        // ============================================================
        enum DrawMode { None, Line, Ellipse, FilledEllipse, Rect, FilledRect, Circle, FilledCircle, Arc, Select }

        List<clsDrawObject> lstObject = new List<clsDrawObject>();
        DrawMode currentMode = DrawMode.None;
        bool isPress = false;
        Color penColor = Color.Blue;
        Color brushColor = Color.LightBlue;
        float penWidth = 2f;
        DashStyle penDash = DashStyle.Solid;
        int brushStyleIndex = -1;

        // Drag/select
        clsDrawObject dragObj = null;
        Point dragStart;
        Point dragObjOriginP1, dragObjOriginP2;
        Point lastDragPos;

        // Arc config
        float arcStart = 0f;
        float arcSweep = 180f;

        // File management
        string currentFilePath = null;
        bool isDirty = false;

        // ============================================================
        //  CONSTRUCTOR
        // ============================================================
        public Form1()
        {
            InitializeComponent();

            this.DoubleBuffered = true;
            typeof(Panel).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.SetProperty |
                System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.NonPublic,
                null, plMain, new object[] { true });

            this.Text = "Paint Application - HCMUTE";
            UpdateColorPreviews();
            UpdateTitle();
        }

        // ============================================================
        //  HELPERS
        // ============================================================
        Pen MakePen()
        {
            var p = new Pen(penColor, penWidth);
            p.DashStyle = penDash;
            return p;
        }
        Brush MakeBrush()
        {
            if (brushStyleIndex < 0)
                return new SolidBrush(brushColor);

            System.Drawing.Drawing2D.HatchStyle[] styles = new System.Drawing.Drawing2D.HatchStyle[]
            {
                System.Drawing.Drawing2D.HatchStyle.Horizontal,
                System.Drawing.Drawing2D.HatchStyle.Vertical,
                System.Drawing.Drawing2D.HatchStyle.ForwardDiagonal,
                System.Drawing.Drawing2D.HatchStyle.BackwardDiagonal,
                System.Drawing.Drawing2D.HatchStyle.Cross,
                System.Drawing.Drawing2D.HatchStyle.DiagonalCross,
                System.Drawing.Drawing2D.HatchStyle.LightUpwardDiagonal,
                System.Drawing.Drawing2D.HatchStyle.DottedGrid,
                System.Drawing.Drawing2D.HatchStyle.Shingle
            };
            return new System.Drawing.Drawing2D.HatchBrush(styles[brushStyleIndex], brushColor, Color.Transparent);
        }

        void UpdateColorPreviews()
        {
            if (panelPenColor != null) panelPenColor.BackColor = penColor;
            if (panelBrushColor != null) panelBrushColor.BackColor = brushColor;
        }

        void UpdateTitle()
        {
            string fileName = currentFilePath != null ? Path.GetFileName(currentFilePath) : "Untitled";
            string dirty = isDirty ? " *" : "";
            this.Text = $"Paint Application - HCMUTE  [{fileName}{dirty}]";
        }

        void MarkDirty()
        {
            isDirty = true;
            UpdateTitle();
        }

        // ============================================================
        //  FILE OPERATIONS
        // ============================================================

        bool PromptSaveIfDirty()
        {
            if (!isDirty) return true;
            string fileName = currentFilePath != null ? Path.GetFileName(currentFilePath) : "Untitled";
            var result = MessageBox.Show(
                $"File \"{fileName}\" có thay đổi chưa được lưu. Bạn có muốn lưu không?",
                "Lưu thay đổi",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes) { SaveFile(); return true; }
            if (result == DialogResult.No) return true;
            return false; // Cancel
        }

        void NewFile()
        {
            if (!PromptSaveIfDirty()) return;
            lstObject.Clear();
            currentFilePath = null;
            isDirty = false;
            UpdateTitle();
            plMain.Refresh();
        }

        void SaveFile()
        {
            if (currentFilePath == null)
                SaveFileAs();
            else
                WriteFile(currentFilePath);
        }

        void SaveFileAs()
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Title = "Lưu file vẽ";
                sfd.Filter = "Paint files (*.pnt)|*.pnt|All files (*.*)|*.*";
                sfd.DefaultExt = "pnt";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    currentFilePath = sfd.FileName;
                    WriteFile(currentFilePath);
                }
            }
        }

        void OpenFile()
        {
            if (!PromptSaveIfDirty()) return;
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Mở file vẽ";
                ofd.Filter = "Paint files (*.pnt)|*.pnt|All files (*.*)|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                    ReadFile(ofd.FileName);
            }
        }

        void WriteFile(string path)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.UTF8))
                    WriteObjects(sw, lstObject);
                isDirty = false;
                UpdateTitle();
                MessageBox.Show("Lưu file thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu file:\n{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void WriteObjects(StreamWriter sw, List<clsDrawObject> objects)
        {
            sw.WriteLine(objects.Count);
            foreach (var obj in objects)
                WriteObject(sw, obj);
        }

        void WriteObject(StreamWriter sw, clsDrawObject obj)
        {
            sw.WriteLine(obj.GetType().Name);
            sw.WriteLine($"{obj.p1.X},{obj.p1.Y}");
            sw.WriteLine($"{obj.p2.X},{obj.p2.Y}");
            sw.WriteLine(obj.PenColorHex);
            sw.WriteLine(obj.PenWidth.ToString(System.Globalization.CultureInfo.InvariantCulture));
            sw.WriteLine(obj.PenDash);
            sw.WriteLine(obj.BrushColorHex);
            sw.WriteLine(obj.BrushHatchStyle);

            if (obj is clsArc arc)
            {
                sw.WriteLine(arc.startAngle.ToString(System.Globalization.CultureInfo.InvariantCulture));
                sw.WriteLine(arc.sweepAngle.ToString(System.Globalization.CultureInfo.InvariantCulture));
            }
            else if (obj is clsGroup grp)
            {
                WriteObjects(sw, grp.children);
            }
        }

        void ReadFile(string path)
        {
            try
            {
                using (StreamReader sr = new StreamReader(path, System.Text.Encoding.UTF8))
                {
                    lstObject = ReadObjects(sr);
                    currentFilePath = path;
                    isDirty = false;
                    UpdateTitle();
                    plMain.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi mở file:\n{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        List<clsDrawObject> ReadObjects(StreamReader sr)
        {
            int count = int.Parse(sr.ReadLine());
            var list = new List<clsDrawObject>();
            for (int i = 0; i < count; i++)
                list.Add(ReadObject(sr));
            return list;
        }

        clsDrawObject ReadObject(StreamReader sr)
        {
            string type = sr.ReadLine();
            var p1Parts = sr.ReadLine().Split(',');
            var p2Parts = sr.ReadLine().Split(',');
            Point p1 = new Point(int.Parse(p1Parts[0]), int.Parse(p1Parts[1]));
            Point p2 = new Point(int.Parse(p2Parts[0]), int.Parse(p2Parts[1]));
            string penColorHex = sr.ReadLine();
            float penW = float.Parse(sr.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
            int penD = int.Parse(sr.ReadLine());
            string brushColorHex = sr.ReadLine();
            int brushH = int.Parse(sr.ReadLine());

            clsDrawObject obj = CreateObjectByType(type);
            obj.p1 = p1;
            obj.p2 = p2;
            obj.ApplySerializedPen(penColorHex, penW, penD);
            obj.ApplySerializedBrush(brushColorHex, brushH);

            if (obj is clsArc arc)
            {
                arc.startAngle = float.Parse(sr.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
                arc.sweepAngle = float.Parse(sr.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
            }
            else if (obj is clsGroup grp)
            {
                grp.children = ReadObjects(sr);
            }

            return obj;
        }

        clsDrawObject CreateObjectByType(string type)
        {
            switch (type)
            {
                case "clsLine": return new clsLine();
                case "clsEllipse": return new clsEllipse();
                case "clsFilledEllipse": return new clsFilledEllipse();
                case "clsRectangle": return new clsRectangle();
                case "clsFilledRectangle": return new clsFilledRectangle();
                case "clsCircle": return new clsCircle();
                case "clsFilledCircle": return new clsFilledCircle();
                case "clsArc": return new clsArc();
                case "clsGroup": return new clsGroup();
                default: throw new Exception($"Unknown object type: {type}");
            }
        }

        // ============================================================
        //  TOOLBAR BUTTON CLICKS
        // ============================================================
        private void SetMode(DrawMode mode, Button activeBtn)
        {
            currentMode = mode;
            Button[] btns = { btnLine, btnEllipse, btnFilledEllipse, btnRect, btnFilledRect,
                              btnCircle, btnFilledCircle, btnArc, btnSelect };
            foreach (var b in btns)
                b.FlatAppearance.BorderColor = (b == activeBtn) ? Color.Orange : Color.Gray;
        }

        private void btnLine_Click(object sender, EventArgs e) => SetMode(DrawMode.Line, btnLine);
        private void btnEllipse_Click(object sender, EventArgs e) => SetMode(DrawMode.Ellipse, btnEllipse);
        private void btnFilledEllipse_Click(object sender, EventArgs e) => SetMode(DrawMode.FilledEllipse, btnFilledEllipse);
        private void btnRect_Click(object sender, EventArgs e) => SetMode(DrawMode.Rect, btnRect);
        private void btnFilledRect_Click(object sender, EventArgs e) => SetMode(DrawMode.FilledRect, btnFilledRect);
        private void btnCircle_Click(object sender, EventArgs e) => SetMode(DrawMode.Circle, btnCircle);
        private void btnFilledCircle_Click(object sender, EventArgs e) => SetMode(DrawMode.FilledCircle, btnFilledCircle);
        private void btnArc_Click(object sender, EventArgs e) => SetMode(DrawMode.Arc, btnArc);
        private void btnSelect_Click(object sender, EventArgs e) => SetMode(DrawMode.Select, btnSelect);

        // File button handlers
        private void btnNew_Click(object sender, EventArgs e) => NewFile();
        private void btnSave_Click(object sender, EventArgs e) => SaveFile();
        private void btnSaveAs_Click(object sender, EventArgs e) => SaveFileAs();
        private void btnOpen_Click(object sender, EventArgs e) => OpenFile();

        private void btnPenColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog cd = new ColorDialog())
            {
                cd.Color = penColor;
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    penColor = cd.Color;
                    UpdateColorPreviews();
                }
            }
        }

        private void btnBrushColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog cd = new ColorDialog())
            {
                cd.Color = brushColor;
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    brushColor = cd.Color;
                    UpdateColorPreviews();
                }
            }
        }

        private void trkWidth_Scroll(object sender, EventArgs e)
        {
            penWidth = trkWidth.Value;
            lblWidth.Text = $"Width: {penWidth}";
        }

        private void cboDashStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            penDash = (DashStyle)cboDashStyle.SelectedIndex;
        }

        private void cboBrushStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            brushStyleIndex = cboBrushStyle.SelectedIndex - 1;
        }

        private void btnGroup_Click(object sender, EventArgs e)
        {
            var selected = lstObject.FindAll(o => o.isSelected && !(o is clsGroup));
            if (selected.Count < 2) { MessageBox.Show("Chọn ít nhất 2 đối tượng để nhóm!", "Group"); return; }
            clsGroup grp = new clsGroup();
            grp.myPen = MakePen();
            foreach (var obj in selected)
            {
                grp.children.Add(obj);
                lstObject.Remove(obj);
            }
            grp.isSelected = true;
            lstObject.Add(grp);
            MarkDirty();
            plMain.Refresh();
        }

        private void btnUngroup_Click(object sender, EventArgs e)
        {
            var groups = lstObject.FindAll(o => o is clsGroup && o.isSelected);
            foreach (clsGroup grp in groups)
            {
                foreach (var child in grp.children)
                    lstObject.Add(child);
                lstObject.Remove(grp);
            }
            MarkDirty();
            plMain.Refresh();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lstObject.RemoveAll(o => o.isSelected);
            MarkDirty();
            plMain.Refresh();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa toàn bộ?", "Clear", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                lstObject.Clear();
                MarkDirty();
                plMain.Refresh();
            }
        }

        private void btnArcConfig_Click(object sender, EventArgs e)
        {
            using (Form f = new Form())
            {
                f.Text = "Arc Config"; f.Size = new Size(300, 160);
                f.FormBorderStyle = FormBorderStyle.FixedDialog;
                f.StartPosition = FormStartPosition.CenterParent;
                var lbl1 = new Label { Text = "Start Angle:", Location = new Point(10, 20), Width = 100 };
                var num1 = new NumericUpDown { Location = new Point(110, 18), Width = 80, Minimum = 0, Maximum = 360, Value = (decimal)arcStart };
                var lbl2 = new Label { Text = "Sweep Angle:", Location = new Point(10, 60), Width = 100 };
                var num2 = new NumericUpDown { Location = new Point(110, 58), Width = 80, Minimum = 1, Maximum = 360, Value = (decimal)arcSweep };
                var btnOK = new Button { Text = "OK", Location = new Point(110, 95), DialogResult = DialogResult.OK };
                f.Controls.AddRange(new Control[] { lbl1, num1, lbl2, num2, btnOK });
                f.AcceptButton = btnOK;
                if (f.ShowDialog() == DialogResult.OK)
                {
                    arcStart = (float)num1.Value;
                    arcSweep = (float)num2.Value;
                }
            }
        }

        // ============================================================
        //  CANVAS EVENTS
        // ============================================================
        private void plMain_MouseDown(object sender, MouseEventArgs e)
        {
            isPress = true;

            if (currentMode == DrawMode.Select)
            {
                dragObj = null;
                for (int i = lstObject.Count - 1; i >= 0; i--)
                {
                    if (lstObject[i].HitTest(e.Location))
                    {
                        if ((Control.ModifierKeys & Keys.Control) == 0)
                            foreach (var o in lstObject) o.isSelected = false;
                        lstObject[i].isSelected = !lstObject[i].isSelected;
                        if (lstObject[i].isSelected)
                        {
                            dragObj = lstObject[i];
                            dragStart = e.Location;
                            lastDragPos = e.Location;
                            dragObjOriginP1 = dragObj.p1;
                            dragObjOriginP2 = dragObj.p2;
                        }
                        plMain.Refresh();
                        return;
                    }
                }
                foreach (var o in lstObject) o.isSelected = false;
                plMain.Refresh();
                return;
            }

            clsDrawObject obj = CreateObject();
            if (obj == null) return;
            obj.myPen = MakePen();
            obj.myBrush = MakeBrush();
            obj.p1 = e.Location;
            obj.p2 = e.Location;
            if (obj is clsArc arc) { arc.startAngle = arcStart; arc.sweepAngle = arcSweep; }
            lstObject.Add(obj);
        }

        private void plMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isPress) return;

            if (currentMode == DrawMode.Select && dragObj != null)
            {
                int dx = e.X - lastDragPos.X;
                int dy = e.Y - lastDragPos.Y;
                lastDragPos = e.Location;
                if (dragObj is clsGroup grp)
                    grp.Move(dx, dy);
                else
                {
                    dragObj.p1 = new Point(dragObj.p1.X + dx, dragObj.p1.Y + dy);
                    dragObj.p2 = new Point(dragObj.p2.X + dx, dragObj.p2.Y + dy);
                }
                plMain.Refresh();
                return;
            }

            if (lstObject.Count > 0 && currentMode != DrawMode.Select)
            {
                lstObject[lstObject.Count - 1].p2 = e.Location;
                plMain.Refresh();
            }
        }

        private void plMain_MouseUp(object sender, MouseEventArgs e)
        {
            isPress = false;
            dragObj = null;
            if (lstObject.Count > 0 && currentMode != DrawMode.Select && currentMode != DrawMode.None)
            {
                lstObject[lstObject.Count - 1].p2 = e.Location;
                MarkDirty();
                plMain.Refresh();
            }
        }

        private void plMain_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            foreach (var obj in lstObject)
                obj.Draw(e.Graphics);
        }

        clsDrawObject CreateObject()
        {
            switch (currentMode)
            {
                case DrawMode.Line: return new clsLine();
                case DrawMode.Ellipse: return new clsEllipse();
                case DrawMode.FilledEllipse: return new clsFilledEllipse();
                case DrawMode.Rect: return new clsRectangle();
                case DrawMode.FilledRect: return new clsFilledRectangle();
                case DrawMode.Circle: return new clsCircle();
                case DrawMode.FilledCircle: return new clsFilledCircle();
                case DrawMode.Arc: return new clsArc();
                default: return null;
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (!PromptSaveIfDirty())
                e.Cancel = true;
        }
    }
}