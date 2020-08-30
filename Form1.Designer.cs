namespace HM_6_T_1_Text_editor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.openAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.colorTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.fillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
            this.pasteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripSeparator();
            this.undoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.undoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newFile_toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openFile_toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.save_toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveAs_toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copy_toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.past_toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.undo_toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.cut_toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.textEditor_Box = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.formatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(731, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFileToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.openAsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.saveToolStripMenuItem1,
            this.toolStripMenuItem2,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newFileToolStripMenuItem
            // 
            this.newFileToolStripMenuItem.Name = "newFileToolStripMenuItem";
            this.newFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newFileToolStripMenuItem.Text = "New file";
            this.newFileToolStripMenuItem.Click += new System.EventHandler(this.newFileToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(177, 6);
            // 
            // openAsToolStripMenuItem
            // 
            this.openAsToolStripMenuItem.Name = "openAsToolStripMenuItem";
            this.openAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openAsToolStripMenuItem.Text = "Open file";
            this.openAsToolStripMenuItem.Click += new System.EventHandler(this.openAsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem1.Text = "Save";
            this.saveToolStripMenuItem1.Click += new System.EventHandler(this.saveToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.toolStripMenuItem5,
            this.pasteToolStripMenuItem,
            this.toolStripMenuItem6,
            this.undoToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(100, 6);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(100, 6);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem,
            this.toolStripMenuItem3,
            this.colorTextToolStripMenuItem,
            this.toolStripMenuItem4,
            this.fillToolStripMenuItem});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.formatToolStripMenuItem.Text = "Format";
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.fontToolStripMenuItem.Text = "Font";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(122, 6);
            // 
            // colorTextToolStripMenuItem
            // 
            this.colorTextToolStripMenuItem.Name = "colorTextToolStripMenuItem";
            this.colorTextToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.colorTextToolStripMenuItem.Text = "Text color";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(122, 6);
            // 
            // fillToolStripMenuItem
            // 
            this.fillToolStripMenuItem.Name = "fillToolStripMenuItem";
            this.fillToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.fillToolStripMenuItem.Text = "Fill";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem1,
            this.toolStripMenuItem7,
            this.pasteToolStripMenuItem1,
            this.toolStripMenuItem8,
            this.undoToolStripMenuItem1,
            this.cutToolStripMenuItem,
            this.undoToolStripMenuItem2});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(104, 110);
            // 
            // copyToolStripMenuItem1
            // 
            this.copyToolStripMenuItem1.Name = "copyToolStripMenuItem1";
            this.copyToolStripMenuItem1.Size = new System.Drawing.Size(103, 22);
            this.copyToolStripMenuItem1.Text = "Copy";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(100, 6);
            // 
            // pasteToolStripMenuItem1
            // 
            this.pasteToolStripMenuItem1.Name = "pasteToolStripMenuItem1";
            this.pasteToolStripMenuItem1.Size = new System.Drawing.Size(103, 22);
            this.pasteToolStripMenuItem1.Text = "Cut";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(100, 6);
            // 
            // undoToolStripMenuItem1
            // 
            this.undoToolStripMenuItem1.Name = "undoToolStripMenuItem1";
            this.undoToolStripMenuItem1.Size = new System.Drawing.Size(103, 22);
            this.undoToolStripMenuItem1.Text = "Past";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(100, 6);
            // 
            // undoToolStripMenuItem2
            // 
            this.undoToolStripMenuItem2.Name = "undoToolStripMenuItem2";
            this.undoToolStripMenuItem2.Size = new System.Drawing.Size(103, 22);
            this.undoToolStripMenuItem2.Text = "Undo";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFile_toolStripButton,
            this.openFile_toolStripButton,
            this.save_toolStripButton,
            this.saveAs_toolStripButton,
            this.copy_toolStripButton,
            this.past_toolStripButton,
            this.undo_toolStripButton,
            this.cut_toolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(731, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // newFile_toolStripButton
            // 
            this.newFile_toolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newFile_toolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newFile_toolStripButton.Image")));
            this.newFile_toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newFile_toolStripButton.Name = "newFile_toolStripButton";
            this.newFile_toolStripButton.Size = new System.Drawing.Size(23, 22);
            this.newFile_toolStripButton.Text = "New file";
            // 
            // openFile_toolStripButton
            // 
            this.openFile_toolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openFile_toolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openFile_toolStripButton.Image")));
            this.openFile_toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openFile_toolStripButton.Name = "openFile_toolStripButton";
            this.openFile_toolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openFile_toolStripButton.Text = "Open file";
            // 
            // save_toolStripButton
            // 
            this.save_toolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.save_toolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("save_toolStripButton.Image")));
            this.save_toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.save_toolStripButton.Name = "save_toolStripButton";
            this.save_toolStripButton.Size = new System.Drawing.Size(23, 22);
            this.save_toolStripButton.Text = "Save file";
            // 
            // saveAs_toolStripButton
            // 
            this.saveAs_toolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveAs_toolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveAs_toolStripButton.Image")));
            this.saveAs_toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveAs_toolStripButton.Name = "saveAs_toolStripButton";
            this.saveAs_toolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveAs_toolStripButton.Text = "Save as";
            // 
            // copy_toolStripButton
            // 
            this.copy_toolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copy_toolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copy_toolStripButton.Image")));
            this.copy_toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copy_toolStripButton.Name = "copy_toolStripButton";
            this.copy_toolStripButton.Size = new System.Drawing.Size(23, 22);
            this.copy_toolStripButton.Text = "Copy";
            // 
            // past_toolStripButton
            // 
            this.past_toolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.past_toolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("past_toolStripButton.Image")));
            this.past_toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.past_toolStripButton.Name = "past_toolStripButton";
            this.past_toolStripButton.Size = new System.Drawing.Size(23, 22);
            this.past_toolStripButton.Text = "Past";
            // 
            // undo_toolStripButton
            // 
            this.undo_toolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.undo_toolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("undo_toolStripButton.Image")));
            this.undo_toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.undo_toolStripButton.Name = "undo_toolStripButton";
            this.undo_toolStripButton.Size = new System.Drawing.Size(23, 22);
            this.undo_toolStripButton.Text = "Undo";
            // 
            // cut_toolStripButton
            // 
            this.cut_toolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cut_toolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cut_toolStripButton.Image")));
            this.cut_toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cut_toolStripButton.Name = "cut_toolStripButton";
            this.cut_toolStripButton.Size = new System.Drawing.Size(23, 22);
            this.cut_toolStripButton.Text = "Cut";
            // 
            // textEditor_Box
            // 
            this.textEditor_Box.ContextMenuStrip = this.contextMenuStrip1;
            this.textEditor_Box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textEditor_Box.Location = new System.Drawing.Point(0, 49);
            this.textEditor_Box.Multiline = true;
            this.textEditor_Box.Name = "textEditor_Box";
            this.textEditor_Box.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textEditor_Box.Size = new System.Drawing.Size(731, 379);
            this.textEditor_Box.TabIndex = 8;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "copy_text.png");
            this.imageList1.Images.SetKeyName(1, "cut_text.png");
            this.imageList1.Images.SetKeyName(2, "new_file.png");
            this.imageList1.Images.SetKeyName(3, "open_file.png");
            this.imageList1.Images.SetKeyName(4, "paste_text.png");
            this.imageList1.Images.SetKeyName(5, "save_file.png");
            this.imageList1.Images.SetKeyName(6, "saveAs_file.png");
            this.imageList1.Images.SetKeyName(7, "undo_text.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 428);
            this.Controls.Add(this.textEditor_Box);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Text editor (v 0.1)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem colorTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem fillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TextBox textEditor_Box;
        private System.Windows.Forms.ToolStripButton newFile_toolStripButton;
        private System.Windows.Forms.ToolStripButton openFile_toolStripButton;
        private System.Windows.Forms.ToolStripButton save_toolStripButton;
        private System.Windows.Forms.ToolStripButton saveAs_toolStripButton;
        private System.Windows.Forms.ToolStripButton copy_toolStripButton;
        private System.Windows.Forms.ToolStripButton past_toolStripButton;
        private System.Windows.Forms.ToolStripButton undo_toolStripButton;
        private System.Windows.Forms.ToolStripButton cut_toolStripButton;
        private System.Windows.Forms.ImageList imageList1;
    }
}

