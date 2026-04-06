namespace PaintApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        // ---- Controls ----
        private System.Windows.Forms.Panel plMain;
        private System.Windows.Forms.Panel pnlToolbar;
        private System.Windows.Forms.Panel pnlProps;

        // Shape buttons
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button btnEllipse;
        private System.Windows.Forms.Button btnFilledEllipse;
        private System.Windows.Forms.Button btnRect;
        private System.Windows.Forms.Button btnFilledRect;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.Button btnFilledCircle;
        private System.Windows.Forms.Button btnArc;
        private System.Windows.Forms.Button btnArcConfig;
        private System.Windows.Forms.Button btnSelect;

        // Action buttons
        private System.Windows.Forms.Button btnGroup;
        private System.Windows.Forms.Button btnUngroup;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;

        // Color
        private System.Windows.Forms.Button btnPenColor;
        private System.Windows.Forms.Panel panelPenColor;
        private System.Windows.Forms.Button btnBrushColor;
        private System.Windows.Forms.Panel panelBrushColor;

        // Pen props
        private System.Windows.Forms.TrackBar trkWidth;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.ComboBox cboDashStyle;
        private System.Windows.Forms.Label lblDash;

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            // ---- Instantiate ----
            plMain = new System.Windows.Forms.Panel();
            pnlToolbar = new System.Windows.Forms.Panel();
            pnlProps = new System.Windows.Forms.Panel();

            btnLine = MakeBtn("Line");
            btnEllipse = MakeBtn("Ellipse");
            btnFilledEllipse = MakeBtn("F.Ellipse");
            btnRect = MakeBtn("Rect");
            btnFilledRect = MakeBtn("F.Rect");
            btnCircle = MakeBtn("Circle");
            btnFilledCircle = MakeBtn("F.Circle");
            btnArc = MakeBtn("Arc");
            btnArcConfig = MakeBtn("Arc Config");
            btnSelect = MakeBtn("↖ Select");

            btnGroup = MakeBtn("Group");
            btnUngroup = MakeBtn("Ungroup");
            btnDelete = MakeBtn("Delete");
            btnClear = MakeBtn("Clear All");

            btnPenColor = new System.Windows.Forms.Button();
            panelPenColor = new System.Windows.Forms.Panel();
            btnBrushColor = new System.Windows.Forms.Button();
            panelBrushColor = new System.Windows.Forms.Panel();

            trkWidth = new System.Windows.Forms.TrackBar();
            lblWidth = new System.Windows.Forms.Label();
            cboDashStyle = new System.Windows.Forms.ComboBox();
            lblDash = new System.Windows.Forms.Label();

            // ---- Form ----
            this.SuspendLayout();
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Text = "Paint Application - HCMUTE Midterm 2026";
            this.BackColor = System.Drawing.Color.FromArgb(40, 40, 40);

            // ============================================================
            //  LEFT TOOLBAR
            // ============================================================
            pnlToolbar.BackColor = System.Drawing.Color.FromArgb(50, 50, 55);
            pnlToolbar.Dock = System.Windows.Forms.DockStyle.Left;
            pnlToolbar.Width = 115;

            int y = 10;

            AddLabel(pnlToolbar, "── SHAPES ──", ref y);

            PlaceBtn(pnlToolbar, btnLine, ref y);
            PlaceBtn(pnlToolbar, btnEllipse, ref y);
            PlaceBtn(pnlToolbar, btnFilledEllipse, ref y);
            PlaceBtn(pnlToolbar, btnRect, ref y);
            PlaceBtn(pnlToolbar, btnFilledRect, ref y);
            PlaceBtn(pnlToolbar, btnCircle, ref y);
            PlaceBtn(pnlToolbar, btnFilledCircle, ref y);
            PlaceBtn(pnlToolbar, btnArc, ref y);
            PlaceBtn(pnlToolbar, btnArcConfig, ref y);

            y += 5;
            AddLabel(pnlToolbar, "── EDIT ──", ref y);

            PlaceBtn(pnlToolbar, btnSelect, ref y);
            PlaceBtn(pnlToolbar, btnGroup, ref y);
            PlaceBtn(pnlToolbar, btnUngroup, ref y);
            PlaceBtn(pnlToolbar, btnDelete, ref y);
            PlaceBtn(pnlToolbar, btnClear, ref y);

            // ============================================================
            //  RIGHT PROPS PANEL
            // ============================================================
            pnlProps.BackColor = System.Drawing.Color.FromArgb(50, 50, 55);
            pnlProps.Dock = System.Windows.Forms.DockStyle.Right;
            pnlProps.Width = 155;

            int py = 10;

            AddLabel(pnlProps, "── PEN COLOR ──", ref py);

            btnPenColor.Location = new System.Drawing.Point(8, py);
            btnPenColor.Size = new System.Drawing.Size(78, 26);
            btnPenColor.Text = "Choose...";
            StyleBtn(btnPenColor);
            pnlProps.Controls.Add(btnPenColor);

            panelPenColor.Location = new System.Drawing.Point(90, py + 1);
            panelPenColor.Size = new System.Drawing.Size(24, 24);
            panelPenColor.BackColor = System.Drawing.Color.Blue;
            panelPenColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlProps.Controls.Add(panelPenColor);
            py += 32;

            AddLabel(pnlProps, "── BRUSH COLOR ──", ref py);

            btnBrushColor.Location = new System.Drawing.Point(8, py);
            btnBrushColor.Size = new System.Drawing.Size(78, 26);
            btnBrushColor.Text = "Choose...";
            StyleBtn(btnBrushColor);
            pnlProps.Controls.Add(btnBrushColor);

            panelBrushColor.Location = new System.Drawing.Point(90, py + 1);
            panelBrushColor.Size = new System.Drawing.Size(24, 24);
            panelBrushColor.BackColor = System.Drawing.Color.LightBlue;
            panelBrushColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlProps.Controls.Add(panelBrushColor);
            py += 38;

            AddLabel(pnlProps, "── PEN WIDTH ──", ref py);

            lblWidth.Text = "Width: 2";
            lblWidth.ForeColor = System.Drawing.Color.Silver;
            lblWidth.Location = new System.Drawing.Point(8, py);
            lblWidth.Size = new System.Drawing.Size(120, 16);
            lblWidth.Font = new System.Drawing.Font("Segoe UI", 8f);
            pnlProps.Controls.Add(lblWidth);
            py += 18;

            trkWidth.Location = new System.Drawing.Point(4, py);
            trkWidth.Size = new System.Drawing.Size(140, 36);
            trkWidth.Minimum = 1;
            trkWidth.Maximum = 20;
            trkWidth.Value = 2;
            trkWidth.TickFrequency = 2;
            trkWidth.BackColor = System.Drawing.Color.FromArgb(50, 50, 55);
            pnlProps.Controls.Add(trkWidth);
            py += 42;

            AddLabel(pnlProps, "── DASH STYLE ──", ref py);

            cboDashStyle.Location = new System.Drawing.Point(8, py);
            cboDashStyle.Size = new System.Drawing.Size(132, 22);
            cboDashStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboDashStyle.Items.AddRange(new object[] { "Solid", "Dash", "Dot", "DashDot", "DashDotDot" });
            cboDashStyle.SelectedIndex = 0;
            cboDashStyle.BackColor = System.Drawing.Color.FromArgb(70, 70, 75);
            cboDashStyle.ForeColor = System.Drawing.Color.White;
            pnlProps.Controls.Add(cboDashStyle);

            // ============================================================
            //  MAIN CANVAS
            // ============================================================
            plMain.BackColor = System.Drawing.Color.White;
            plMain.Dock = System.Windows.Forms.DockStyle.Fill;
            plMain.Cursor = System.Windows.Forms.Cursors.Cross;
            plMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // ---- Wire up events ----
            plMain.MouseDown += plMain_MouseDown;
            plMain.MouseMove += plMain_MouseMove;
            plMain.MouseUp += plMain_MouseUp;
            plMain.Paint += plMain_Paint;

            btnLine.Click += btnLine_Click;
            btnEllipse.Click += btnEllipse_Click;
            btnFilledEllipse.Click += btnFilledEllipse_Click;
            btnRect.Click += btnRect_Click;
            btnFilledRect.Click += btnFilledRect_Click;
            btnCircle.Click += btnCircle_Click;
            btnFilledCircle.Click += btnFilledCircle_Click;
            btnArc.Click += btnArc_Click;
            btnArcConfig.Click += btnArcConfig_Click;
            btnSelect.Click += btnSelect_Click;
            btnGroup.Click += btnGroup_Click;
            btnUngroup.Click += btnUngroup_Click;
            btnDelete.Click += btnDelete_Click;
            btnClear.Click += btnClear_Click;
            btnPenColor.Click += btnPenColor_Click;
            btnBrushColor.Click += btnBrushColor_Click;
            trkWidth.Scroll += trkWidth_Scroll;
            cboDashStyle.SelectedIndexChanged += cboDashStyle_SelectedIndexChanged;

            // ---- Add to form ----
            this.Controls.Add(plMain);
            this.Controls.Add(pnlToolbar);
            this.Controls.Add(pnlProps);

            this.ResumeLayout(false);
        }

        // ---- Helpers ----
        System.Windows.Forms.Button MakeBtn(string text)
        {
            var b = new System.Windows.Forms.Button();
            b.Text = text;
            b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            b.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(90, 90, 90);
            b.FlatAppearance.BorderSize = 1;
            b.BackColor = System.Drawing.Color.FromArgb(68, 68, 75);
            b.ForeColor = System.Drawing.Color.WhiteSmoke;
            b.Font = new System.Drawing.Font("Segoe UI", 8f);
            b.Cursor = System.Windows.Forms.Cursors.Hand;
            b.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            return b;
        }

        void StyleBtn(System.Windows.Forms.Button b)
        {
            b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            b.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(90, 90, 90);
            b.BackColor = System.Drawing.Color.FromArgb(68, 68, 75);
            b.ForeColor = System.Drawing.Color.WhiteSmoke;
            b.Font = new System.Drawing.Font("Segoe UI", 8f);
            b.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        void PlaceBtn(System.Windows.Forms.Panel panel, System.Windows.Forms.Button b, ref int y)
        {
            b.Location = new System.Drawing.Point(8, y);
            b.Size = new System.Drawing.Size(98, 27);
            panel.Controls.Add(b);
            y += 30;
        }

        void AddLabel(System.Windows.Forms.Panel panel, string text, ref int y)
        {
            var lbl = new System.Windows.Forms.Label
            {
                Text = text,
                ForeColor = System.Drawing.Color.FromArgb(150, 150, 160),
                Font = new System.Drawing.Font("Segoe UI", 7f, System.Drawing.FontStyle.Bold),
                Location = new System.Drawing.Point(4, y),
                Size = new System.Drawing.Size(148, 14),
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            };
            panel.Controls.Add(lbl);
            y += 17;
        }

        #endregion
    }
}