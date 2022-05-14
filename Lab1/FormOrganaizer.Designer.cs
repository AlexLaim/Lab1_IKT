
namespace Lab1
{
    partial class FormOrganaizer
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
            this.view = new System.Windows.Forms.GroupBox();
            this.list = new System.Windows.Forms.ComboBox();
            this.category = new System.Windows.Forms.RadioButton();
            this.events = new System.Windows.Forms.RadioButton();
            this.lvTable = new System.Windows.Forms.ListView();
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Event = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.operations = new System.Windows.Forms.GroupBox();
            this.add = new System.Windows.Forms.Button();
            this.find = new System.Windows.Forms.Button();
            this.filter = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.Remove = new System.Windows.Forms.ToolStripMenuItem();
            this.view.SuspendLayout();
            this.operations.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // view
            // 
            this.view.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.view.Controls.Add(this.list);
            this.view.Controls.Add(this.category);
            this.view.Controls.Add(this.events);
            this.view.Location = new System.Drawing.Point(0, 7);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(306, 80);
            this.view.TabIndex = 3;
            this.view.TabStop = false;
            this.view.Text = "View";
            // 
            // list
            // 
            this.list.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.list.FormattingEnabled = true;
            this.list.Items.AddRange(new object[] {
            "Memo",
            "Meeting",
            "Task"});
            this.list.Location = new System.Drawing.Point(155, 23);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(121, 21);
            this.list.TabIndex = 2;
            this.list.SelectedIndexChanged += new System.EventHandler(this.list_SelectedIndexChanged);
            // 
            // category
            // 
            this.category.AutoSize = true;
            this.category.Location = new System.Drawing.Point(11, 23);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(94, 17);
            this.category.TabIndex = 0;
            this.category.TabStop = true;
            this.category.Text = "All by category";
            this.category.UseVisualStyleBackColor = true;
            this.category.CheckedChanged += new System.EventHandler(this.category_CheckedChanged);
            // 
            // events
            // 
            this.events.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.events.AutoSize = true;
            this.events.Checked = true;
            this.events.Location = new System.Drawing.Point(11, 59);
            this.events.Name = "events";
            this.events.Size = new System.Drawing.Size(71, 17);
            this.events.TabIndex = 1;
            this.events.TabStop = true;
            this.events.Text = "All evenst";
            this.events.UseVisualStyleBackColor = true;
            this.events.CheckedChanged += new System.EventHandler(this.events_CheckedChanged);
            // 
            // lvTable
            // 
            this.lvTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvTable.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lvTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Date,
            this.Time,
            this.Event,
            this.Type});
            this.lvTable.GridLines = true;
            this.lvTable.HideSelection = false;
            this.lvTable.Location = new System.Drawing.Point(0, 89);
            this.lvTable.Name = "lvTable";
            this.lvTable.Size = new System.Drawing.Size(306, 307);
            this.lvTable.TabIndex = 1;
            this.lvTable.UseCompatibleStateImageBehavior = false;
            this.lvTable.View = System.Windows.Forms.View.Details;
            this.lvTable.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvTable_KeyDown);
            this.lvTable.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvTable_MouseClick);
            // 
            // Date
            // 
            this.Date.Text = "Data";
            this.Date.Width = 87;
            // 
            // Time
            // 
            this.Time.Text = "Time";
            this.Time.Width = 74;
            // 
            // Event
            // 
            this.Event.Text = "Event";
            this.Event.Width = 73;
            // 
            // Type
            // 
            this.Type.Text = "Type";
            this.Type.Width = 68;
            // 
            // operations
            // 
            this.operations.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.operations.AutoSize = true;
            this.operations.Controls.Add(this.add);
            this.operations.Controls.Add(this.find);
            this.operations.Controls.Add(this.filter);
            this.operations.Location = new System.Drawing.Point(0, 396);
            this.operations.Name = "operations";
            this.operations.Padding = new System.Windows.Forms.Padding(5);
            this.operations.Size = new System.Drawing.Size(306, 127);
            this.operations.TabIndex = 4;
            this.operations.TabStop = false;
            this.operations.Text = "Operations";
            // 
            // add
            // 
            this.add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.add.AutoSize = true;
            this.add.Location = new System.Drawing.Point(205, 21);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(93, 80);
            this.add.TabIndex = 7;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // find
            // 
            this.find.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.find.AutoSize = true;
            this.find.Location = new System.Drawing.Point(106, 21);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(93, 80);
            this.find.TabIndex = 6;
            this.find.Text = "Find";
            this.find.UseVisualStyleBackColor = true;
            this.find.Click += new System.EventHandler(this.find_Click);
            // 
            // filter
            // 
            this.filter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.filter.AutoSize = true;
            this.filter.Location = new System.Drawing.Point(8, 21);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(93, 80);
            this.filter.TabIndex = 5;
            this.filter.Text = "Filter";
            this.filter.UseVisualStyleBackColor = true;
            this.filter.Click += new System.EventHandler(this.filter_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Edit,
            this.Remove});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(118, 48);
            // 
            // Edit
            // 
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(117, 22);
            this.Edit.Text = "Edit";
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Remove
            // 
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(117, 22);
            this.Remove.Text = "Remove";
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // FormOrganaizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 520);
            this.Controls.Add(this.operations);
            this.Controls.Add(this.lvTable);
            this.Controls.Add(this.view);
            this.MinimumSize = new System.Drawing.Size(322, 559);
            this.Name = "FormOrganaizer";
            this.Text = "FormOrganaizer";
            this.Activated += new System.EventHandler(this.FormOrganaizer_Activated);
            this.Load += new System.EventHandler(this.FormOrganaizer_Load);
            this.view.ResumeLayout(false);
            this.view.PerformLayout();
            this.operations.ResumeLayout(false);
            this.operations.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox view;
        private System.Windows.Forms.ComboBox list;
        private System.Windows.Forms.RadioButton category;
        private System.Windows.Forms.RadioButton events;
        private System.Windows.Forms.ListView lvTable;
        private System.Windows.Forms.GroupBox operations;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button find;
        private System.Windows.Forms.Button filter;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader Time;
        private System.Windows.Forms.ColumnHeader Event;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Edit;
        private System.Windows.Forms.ToolStripMenuItem Remove;
    }
}