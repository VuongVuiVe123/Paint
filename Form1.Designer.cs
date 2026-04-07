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

        private void InitializeComponent()
        {
            this.plMain = new System.Windows.Forms.Panel();
            this.pnlToolbar = new System.Windows.Forms.Panel();
            this.pnlProps = new System.Windows.Forms.Panel();

            this.btnLine = new System.Windows.Forms.Button();
            this.btnEllipse = new System.Windows.Forms.Button();
            this.btnFilledEllipse = new System.Windows.Forms.Button();
            this.btnRect = new System.Windows.Forms.Button();
            this.btnFilledRect = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.btnFilledCircle = new System.Windows.Forms.Button();
            this.btnArc = new System.Windows.Forms.Button();
            this.btnArcConfig = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();

            this.btnGroup = new System.Windows.Forms.Button();
            this.btnUngroup = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();

            this.btnPenColor = new System.Windows.Forms.Button();
            this.panelPenColor = new System.Windows.Forms.Panel();
            this.btnBrushColor = new System.Windows.Forms.Button();
            this.panelBrushColor = new System.Windows.Forms.Panel();

            this.trkWidth = new System.Windows.Forms.TrackBar();
            this.lblWidth = new System.Windows.Forms.Label();
            this.cboDashStyle = new System.Windows.Forms.ComboBox();
            this.lblDash = new System.Windows.Forms.Label();
            this.cboBrushStyle = new System.Windows.Forms.ComboBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSaveAs = new System.Windows.Forms.Button();

            this.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkWidth)).BeginInit();

            // ============================================================
            //  FORM
            // ============================================================
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Text = "Paint Application - HCMUTE Midterm 2026";
            this.BackColor = System.Drawing.Color.FromArgb(40, 40, 40);
            this.Name = "Form1";

            // ============================================================
            //  LEFT TOOLBAR
            // ============================================================
            this.pnlToolbar.BackColor = System.Drawing.Color.FromArgb(50, 50, 55);
            this.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlToolbar.Width = 115;
            this.pnlToolbar.Name = "pnlToolbar";

            var lblShapes = new System.Windows.Forms.Label();
            lblShapes.Text = "── SHAPES ──";
            lblShapes.ForeColor = System.Drawing.Color.FromArgb(150, 150, 160);
            lblShapes.Font = new System.Drawing.Font("Segoe UI", 7f, System.Drawing.FontStyle.Bold);
            lblShapes.Location = new System.Drawing.Point(4, 10);
            lblShapes.Size = new System.Drawing.Size(106, 14);
            lblShapes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pnlToolbar.Controls.Add(lblShapes);

            this.btnLine.Text = "Line";
            this.btnLine.Location = new System.Drawing.Point(8, 27);
            this.btnLine.Size = new System.Drawing.Size(98, 27);
            this.btnLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLine.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(90, 90, 90);
            this.btnLine.FlatAppearance.BorderSize = 1;
            this.btnLine.BackColor = System.Drawing.Color.FromArgb(68, 68, 75);
            this.btnLine.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLine.Font = new System.Drawing.Font("Segoe UI", 8f);
            this.btnLine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLine.Name = "btnLine";
            this.pnlToolbar.Controls.Add(this.btnLine);

            this.btnEllipse.Text = "Ellipse";
            this.btnEllipse.Location = new System.Drawing.Point(8, 57);
            this.btnEllipse.Size = new System.Drawing.Size(98, 27);
            this.btnEllipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEllipse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(90, 90, 90);
            this.btnEllipse.FlatAppearance.BorderSize = 1;
            this.btnEllipse.BackColor = System.Drawing.Color.FromArgb(68, 68, 75);
            this.btnEllipse.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEllipse.Font = new System.Drawing.Font("Segoe UI", 8f);
            this.btnEllipse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEllipse.Name = "btnEllipse";
            this.pnlToolbar.Controls.Add(this.btnEllipse);

            this.btnFilledEllipse.Text = "F.Ellipse";
            this.btnFilledEllipse.Location = new System.Drawing.Point(8, 87);
            this.btnFilledEllipse.Size = new System.Drawing.Size(98, 27);
            this.btnFilledEllipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilledEllipse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(90, 90, 90);
            this.btnFilledEllipse.FlatAppearance.BorderSize = 1;
            this.btnFilledEllipse.BackColor = System.Drawing.Color.FromArgb(68, 68, 75);
            this.btnFilledEllipse.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnFilledEllipse.Font = new System.Drawing.Font("Segoe UI", 8f);
            this.btnFilledEllipse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilledEllipse.Name = "btnFilledEllipse";
            this.pnlToolbar.Controls.Add(this.btnFilledEllipse);

            this.btnRect.Text = "Rect";
            this.btnRect.Location = new System.Drawing.Point(8, 117);
            this.btnRect.Size = new System.Drawing.Size(98, 27);
            this.btnRect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(90, 90, 90);
            this.btnRect.FlatAppearance.BorderSize = 1;
            this.btnRect.BackColor = System.Drawing.Color.FromArgb(68, 68, 75);
            this.btnRect.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRect.Font = new System.Drawing.Font("Segoe UI", 8f);
            this.btnRect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRect.Name = "btnRect";
            this.pnlToolbar.Controls.Add(this.btnRect);

            this.btnFilledRect.Text = "F.Rect";
            this.btnFilledRect.Location = new System.Drawing.Point(8, 147);
            this.btnFilledRect.Size = new System.Drawing.Size(98, 27);
            this.btnFilledRect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilledRect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(90, 90, 90);
            this.btnFilledRect.FlatAppearance.BorderSize = 1;
            this.btnFilledRect.BackColor = System.Drawing.Color.FromArgb(68, 68, 75);
            this.btnFilledRect.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnFilledRect.Font = new System.Drawing.Font("Segoe UI", 8f);
            this.btnFilledRect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilledRect.Name = "btnFilledRect";
            this.pnlToolbar.Controls.Add(this.btnFilledRect);

            this.btnCircle.Text = "Circle";
            this.btnCircle.Location = new System.Drawing.Point(8, 177);
            this.btnCircle.Size = new System.Drawing.Size(98, 27);
            this.btnCircle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCircle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(90, 90, 90);
            this.btnCircle.FlatAppearance.BorderSize = 1;
            this.btnCircle.BackColor = System.Drawing.Color.FromArgb(68, 68, 75);
            this.btnCircle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCircle.Font = new System.Drawing.Font("Segoe UI", 8f);
            this.btnCircle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCircle.Name = "btnCircle";
            this.pnlToolbar.Controls.Add(this.btnCircle);

            this.btnFilledCircle.Text = "F.Circle";
            this.btnFilledCircle.Location = new System.Drawing.Point(8, 207);
            this.btnFilledCircle.Size = new System.Drawing.Size(98, 27);
            this.btnFilledCircle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilledCircle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(90, 90, 90);
            this.btnFilledCircle.FlatAppearance.BorderSize = 1;
            this.btnFilledCircle.BackColor = System.Drawing.Color.FromArgb(68, 68, 75);
            this.btnFilledCircle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnFilledCircle.Font = new System.Drawing.Font("Segoe UI", 8f);
            this.btnFilledCircle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilledCircle.Name = "btnFilledCircle";
            this.pnlToolbar.Controls.Add(this.btnFilledCircle);

            this.btnArc.Text = "Arc";
            this.btnArc.Location = new System.Drawing.Point(8, 237);
            this.btnArc.Size = new System.Drawing.Size(98, 27);
            this.btnArc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArc.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(90, 90, 90);
            this.btnArc.FlatAppearance.BorderSize = 1;
            this.btnArc.BackColor = System.Drawing.Color.FromArgb(68, 68, 75);
            this.btnArc.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnArc.Font = new System.Drawing.Font("Segoe UI", 8f);
            this.btnArc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArc.Name = "btnArc";
            this.pnlToolbar.Controls.Add(this.btnArc);

            this.btnArcConfig.Text = "Arc Config";
            this.btnArcConfig.Location = new System.Drawing.Point(8, 267);
            this.btnArcConfig.Size = new System.Drawing.Size(98, 27);
            this.btnArcConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArcConfig.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(90, 90, 90);
            this.btnArcConfig.FlatAppearance.BorderSize = 1;
            this.btnArcConfig.BackColor = System.Drawing.Color.FromArgb(68, 68, 75);
            this.btnArcConfig.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnArcConfig.Font = new System.Drawing.Font("Segoe UI", 8f);
            this.btnArcConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArcConfig.Name = "btnArcConfig";
            this.pnlToolbar.Controls.Add(this.btnArcConfig);

            var lblEdit = new System.Windows.Forms.Label();
            lblEdit.Text = "── EDIT ──";
            lblEdit.ForeColor = System.Drawing.Color.FromArgb(150, 150, 160);
            lblEdit.Font = new System.Drawing.Font("Segoe UI", 7f, System.Drawing.FontStyle.Bold);
            lblEdit.Location = new System.Drawing.Point(4, 302);
            lblEdit.Size = new System.Drawing.Size(106, 14);
            lblEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pnlToolbar.Controls.Add(lblEdit);

            this.btnSelect.Text = "↖ Select";
            this.btnSelect.Location = new System.Drawing.Point(8, 319);
            this.btnSelect.Size = new System.Drawing.Size(98, 27);
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(90, 90, 90);
            this.btnSelect.FlatAppearance.BorderSize = 1;
            this.btnSelect.BackColor = System.Drawing.Color.FromArgb(68, 68, 75);
            this.btnSelect.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSelect.Font = new System.Drawing.Font("Segoe UI", 8f);
            this.btnSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelect.Name = "btnSelect";
            this.pnlToolbar.Controls.Add(this.btnSelect);

            this.btnGroup.Text = "Group";
            this.btnGroup.Location = new System.Drawing.Point(8, 349);
            this.btnGroup.Size = new System.Drawing.Size(98, 27);
            this.btnGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGroup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(90, 90, 90);
            this.btnGroup.FlatAppearance.BorderSize = 1;
            this.btnGroup.BackColor = System.Drawing.Color.FromArgb(68, 68, 75);
            this.btnGroup.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGroup.Font = new System.Drawing.Font("Segoe UI", 8f);
            this.btnGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGroup.Name = "btnGroup";
            this.pnlToolbar.Controls.Add(this.btnGroup);

            this.btnUngroup.Text = "Ungroup";
            this.btnUngroup.Location = new System.Drawing.Point(8, 379);
            this.btnUngroup.Size = new System.Drawing.Size(98, 27);
            this.btnUngroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUngroup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(90, 90, 90);
            this.btnUngroup.FlatAppearance.BorderSize = 1;
            this.btnUngroup.BackColor = System.Drawing.Color.FromArgb(68, 68, 75);
            this.btnUngroup.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnUngroup.Font = new System.Drawing.Font("Segoe UI", 8f);
            this.btnUngroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUngroup.Name = "btnUngroup";
            this.pnlToolbar.Controls.Add(this.btnUngroup);

            this.btnDelete.Text = "Delete";
            this.btnDelete.Location = new System.Drawing.Point(8, 409);
            this.btnDelete.Size = new System.Drawing.Size(98, 27);
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(90, 90, 90);
            this.btnDelete.FlatAppearance.BorderSize = 1;
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(68, 68, 75);
            this.btnDelete.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 8f);
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Name = "btnDelete";
            this.pnlToolbar.Controls.Add(this.btnDelete);

            this.btnClear.Text = "Clear All";
            this.btnClear.Location = new System.Drawing.Point(8, 439);
            this.btnClear.Size = new System.Drawing.Size(98, 27);
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(90, 90, 90);
            this.btnClear.FlatAppearance.BorderSize = 1;
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(68, 68, 75);
            this.btnClear.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 8f);
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Name = "btnClear";
            this.pnlToolbar.Controls.Add(this.btnClear);

            // FILE section
            var lblFile = new System.Windows.Forms.Label();
            lblFile.Text = "-- FILE --";
            lblFile.ForeColor = System.Drawing.Color.FromArgb(150, 150, 160);
            lblFile.Font = new System.Drawing.Font("Segoe UI", 7f, System.Drawing.FontStyle.Bold);
            lblFile.Location = new System.Drawing.Point(4, 475);
            lblFile.Size = new System.Drawing.Size(106, 14);
            lblFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pnlToolbar.Controls.Add(lblFile);

            this.btnNew.Text = "New";
            this.btnNew.Location = new System.Drawing.Point(8, 492);
            this.btnNew.Size = new System.Drawing.Size(98, 27);
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(90, 90, 90);
            this.btnNew.FlatAppearance.BorderSize = 1;
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(50, 80, 60);
            this.btnNew.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 8f);
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.Name = "btnNew";
            this.pnlToolbar.Controls.Add(this.btnNew);

            this.btnOpen.Text = "Open";
            this.btnOpen.Location = new System.Drawing.Point(8, 522);
            this.btnOpen.Size = new System.Drawing.Size(98, 27);
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(90, 90, 90);
            this.btnOpen.FlatAppearance.BorderSize = 1;
            this.btnOpen.BackColor = System.Drawing.Color.FromArgb(50, 70, 100);
            this.btnOpen.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnOpen.Font = new System.Drawing.Font("Segoe UI", 8f);
            this.btnOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpen.Name = "btnOpen";
            this.pnlToolbar.Controls.Add(this.btnOpen);

            this.btnSave.Text = "Save";
            this.btnSave.Location = new System.Drawing.Point(8, 552);
            this.btnSave.Size = new System.Drawing.Size(98, 27);
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(90, 90, 90);
            this.btnSave.FlatAppearance.BorderSize = 1;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(80, 60, 100);
            this.btnSave.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 8f);
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Name = "btnSave";
            this.pnlToolbar.Controls.Add(this.btnSave);

            this.btnSaveAs.Text = "Save As...";
            this.btnSaveAs.Location = new System.Drawing.Point(8, 582);
            this.btnSaveAs.Size = new System.Drawing.Size(98, 27);
            this.btnSaveAs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveAs.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(90, 90, 90);
            this.btnSaveAs.FlatAppearance.BorderSize = 1;
            this.btnSaveAs.BackColor = System.Drawing.Color.FromArgb(68, 68, 75);
            this.btnSaveAs.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSaveAs.Font = new System.Drawing.Font("Segoe UI", 8f);
            this.btnSaveAs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveAs.Name = "btnSaveAs";
            this.pnlToolbar.Controls.Add(this.btnSaveAs);

            // ============================================================
            //  RIGHT PROPS PANEL
            // ============================================================
            this.pnlProps.BackColor = System.Drawing.Color.FromArgb(50, 50, 55);
            this.pnlProps.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlProps.Width = 155;
            this.pnlProps.Name = "pnlProps";

            var lblPenColor = new System.Windows.Forms.Label();
            lblPenColor.Text = "── PEN COLOR ──";
            lblPenColor.ForeColor = System.Drawing.Color.FromArgb(150, 150, 160);
            lblPenColor.Font = new System.Drawing.Font("Segoe UI", 7f, System.Drawing.FontStyle.Bold);
            lblPenColor.Location = new System.Drawing.Point(4, 10);
            lblPenColor.Size = new System.Drawing.Size(148, 14);
            lblPenColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pnlProps.Controls.Add(lblPenColor);

            this.btnPenColor.Text = "Choose...";
            this.btnPenColor.Location = new System.Drawing.Point(8, 27);
            this.btnPenColor.Size = new System.Drawing.Size(78, 26);
            this.btnPenColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPenColor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(90, 90, 90);
            this.btnPenColor.BackColor = System.Drawing.Color.FromArgb(68, 68, 75);
            this.btnPenColor.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPenColor.Font = new System.Drawing.Font("Segoe UI", 8f);
            this.btnPenColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPenColor.Name = "btnPenColor";
            this.pnlProps.Controls.Add(this.btnPenColor);

            this.panelPenColor.Location = new System.Drawing.Point(90, 28);
            this.panelPenColor.Size = new System.Drawing.Size(24, 24);
            this.panelPenColor.BackColor = System.Drawing.Color.Blue;
            this.panelPenColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPenColor.Name = "panelPenColor";
            this.pnlProps.Controls.Add(this.panelPenColor);

            var lblBrushColor = new System.Windows.Forms.Label();
            lblBrushColor.Text = "── BRUSH COLOR ──";
            lblBrushColor.ForeColor = System.Drawing.Color.FromArgb(150, 150, 160);
            lblBrushColor.Font = new System.Drawing.Font("Segoe UI", 7f, System.Drawing.FontStyle.Bold);
            lblBrushColor.Location = new System.Drawing.Point(4, 59);
            lblBrushColor.Size = new System.Drawing.Size(148, 14);
            lblBrushColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pnlProps.Controls.Add(lblBrushColor);

            this.btnBrushColor.Text = "Choose...";
            this.btnBrushColor.Location = new System.Drawing.Point(8, 76);
            this.btnBrushColor.Size = new System.Drawing.Size(78, 26);
            this.btnBrushColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrushColor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(90, 90, 90);
            this.btnBrushColor.BackColor = System.Drawing.Color.FromArgb(68, 68, 75);
            this.btnBrushColor.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBrushColor.Font = new System.Drawing.Font("Segoe UI", 8f);
            this.btnBrushColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrushColor.Name = "btnBrushColor";
            this.pnlProps.Controls.Add(this.btnBrushColor);

            this.panelBrushColor.Location = new System.Drawing.Point(90, 77);
            this.panelBrushColor.Size = new System.Drawing.Size(24, 24);
            this.panelBrushColor.BackColor = System.Drawing.Color.LightBlue;
            this.panelBrushColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBrushColor.Name = "panelBrushColor";
            this.pnlProps.Controls.Add(this.panelBrushColor);

            var lblPenWidth = new System.Windows.Forms.Label();
            lblPenWidth.Text = "── PEN WIDTH ──";
            lblPenWidth.ForeColor = System.Drawing.Color.FromArgb(150, 150, 160);
            lblPenWidth.Font = new System.Drawing.Font("Segoe UI", 7f, System.Drawing.FontStyle.Bold);
            lblPenWidth.Location = new System.Drawing.Point(4, 114);
            lblPenWidth.Size = new System.Drawing.Size(148, 14);
            lblPenWidth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pnlProps.Controls.Add(lblPenWidth);

            this.lblWidth.Text = "Width: 2";
            this.lblWidth.ForeColor = System.Drawing.Color.Silver;
            this.lblWidth.Location = new System.Drawing.Point(8, 131);
            this.lblWidth.Size = new System.Drawing.Size(120, 16);
            this.lblWidth.Font = new System.Drawing.Font("Segoe UI", 8f);
            this.lblWidth.Name = "lblWidth";
            this.pnlProps.Controls.Add(this.lblWidth);

            this.trkWidth.Location = new System.Drawing.Point(4, 149);
            this.trkWidth.Size = new System.Drawing.Size(140, 36);
            this.trkWidth.Minimum = 1;
            this.trkWidth.Maximum = 20;
            this.trkWidth.Value = 2;
            this.trkWidth.TickFrequency = 2;
            this.trkWidth.BackColor = System.Drawing.Color.FromArgb(50, 50, 55);
            this.trkWidth.Name = "trkWidth";
            this.pnlProps.Controls.Add(this.trkWidth);

            var lblDashStyle = new System.Windows.Forms.Label();
            lblDashStyle.Text = "── DASH STYLE ──";
            lblDashStyle.ForeColor = System.Drawing.Color.FromArgb(150, 150, 160);
            lblDashStyle.Font = new System.Drawing.Font("Segoe UI", 7f, System.Drawing.FontStyle.Bold);
            lblDashStyle.Location = new System.Drawing.Point(4, 191);
            lblDashStyle.Size = new System.Drawing.Size(148, 14);
            lblDashStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pnlProps.Controls.Add(lblDashStyle);

            this.cboDashStyle.Location = new System.Drawing.Point(8, 208);
            this.cboDashStyle.Size = new System.Drawing.Size(132, 22);
            this.cboDashStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDashStyle.Items.AddRange(new object[] { "Solid", "Dash", "Dot", "DashDot", "DashDotDot" });
            this.cboDashStyle.SelectedIndex = 0;
            this.cboDashStyle.BackColor = System.Drawing.Color.FromArgb(70, 70, 75);
            this.cboDashStyle.ForeColor = System.Drawing.Color.White;
            this.cboDashStyle.Name = "cboDashStyle";
            this.pnlProps.Controls.Add(this.cboDashStyle);

            // Label "BRUSH STYLE"
            var lblBrushStyleHdr = new System.Windows.Forms.Label();
            lblBrushStyleHdr.Text = "── BRUSH STYLE ──";
            lblBrushStyleHdr.ForeColor = System.Drawing.Color.FromArgb(150, 150, 160);
            lblBrushStyleHdr.Font = new System.Drawing.Font("Segoe UI", 7f, System.Drawing.FontStyle.Bold);
            lblBrushStyleHdr.Location = new System.Drawing.Point(4, 237);
            lblBrushStyleHdr.Size = new System.Drawing.Size(148, 14);
            lblBrushStyleHdr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pnlProps.Controls.Add(lblBrushStyleHdr);

            // cboBrushStyle
            this.cboBrushStyle.Location = new System.Drawing.Point(8, 254);
            this.cboBrushStyle.Size = new System.Drawing.Size(132, 22);
            this.cboBrushStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBrushStyle.Items.AddRange(new object[] {
                "Solid", "Horizontal", "Vertical", "ForwardDiag",
                "BackwardDiag", "Cross", "DiagCross", "LightUpwardDiagonal",
                "DottedGrid", "Shingle" });
            this.cboBrushStyle.SelectedIndex = 0;
            this.cboBrushStyle.BackColor = System.Drawing.Color.FromArgb(70, 70, 75);
            this.cboBrushStyle.ForeColor = System.Drawing.Color.White;
            this.cboBrushStyle.Name = "cboBrushStyle";
            this.pnlProps.Controls.Add(this.cboBrushStyle);

            // ============================================================
            //  MAIN CANVAS
            // ============================================================
            this.plMain.BackColor = System.Drawing.Color.White;
            this.plMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plMain.Cursor = System.Windows.Forms.Cursors.Cross;
            this.plMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plMain.Name = "plMain";

            // ============================================================
            //  WIRE UP EVENTS
            // ============================================================
            this.plMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.plMain_MouseDown);
            this.plMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.plMain_MouseMove);
            this.plMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.plMain_MouseUp);
            this.plMain.Paint += new System.Windows.Forms.PaintEventHandler(this.plMain_Paint);

            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            this.btnEllipse.Click += new System.EventHandler(this.btnEllipse_Click);
            this.btnFilledEllipse.Click += new System.EventHandler(this.btnFilledEllipse_Click);
            this.btnRect.Click += new System.EventHandler(this.btnRect_Click);
            this.btnFilledRect.Click += new System.EventHandler(this.btnFilledRect_Click);
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            this.btnFilledCircle.Click += new System.EventHandler(this.btnFilledCircle_Click);
            this.btnArc.Click += new System.EventHandler(this.btnArc_Click);
            this.btnArcConfig.Click += new System.EventHandler(this.btnArcConfig_Click);
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            this.btnGroup.Click += new System.EventHandler(this.btnGroup_Click);
            this.btnUngroup.Click += new System.EventHandler(this.btnUngroup_Click);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            this.btnPenColor.Click += new System.EventHandler(this.btnPenColor_Click);
            this.btnBrushColor.Click += new System.EventHandler(this.btnBrushColor_Click);
            this.trkWidth.Scroll += new System.EventHandler(this.trkWidth_Scroll);
            this.cboDashStyle.SelectedIndexChanged += new System.EventHandler(this.cboDashStyle_SelectedIndexChanged);
            this.cboBrushStyle.SelectedIndexChanged += new System.EventHandler(this.cboBrushStyle_SelectedIndexChanged);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSaveAs.Click += new System.EventHandler(this.btnSaveAs_Click);

            // ============================================================
            //  ADD TO FORM
            // ============================================================
            this.Controls.Add(this.plMain);
            this.Controls.Add(this.pnlToolbar);
            this.Controls.Add(this.pnlProps);

            ((System.ComponentModel.ISupportInitialize)(this.trkWidth)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel plMain;
        private System.Windows.Forms.Panel pnlToolbar;
        private System.Windows.Forms.Panel pnlProps;

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

        private System.Windows.Forms.Button btnGroup;
        private System.Windows.Forms.Button btnUngroup;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;

        private System.Windows.Forms.Button btnPenColor;
        private System.Windows.Forms.Panel panelPenColor;
        private System.Windows.Forms.Button btnBrushColor;
        private System.Windows.Forms.Panel panelBrushColor;

        private System.Windows.Forms.TrackBar trkWidth;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.ComboBox cboDashStyle;
        private System.Windows.Forms.Label lblDash;
        private System.Windows.Forms.ComboBox cboBrushStyle;

        // File buttons
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSaveAs;
    }
}