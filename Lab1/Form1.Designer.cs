
namespace Lab1
{
    partial class Init
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.login = new System.Windows.Forms.TextBox();
            this.log = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.showpass = new System.Windows.Forms.CheckBox();
            this.cancel = new System.Windows.Forms.Button();
            this.Username = new System.Windows.Forms.Label();
            this.passname = new System.Windows.Forms.Label();
            this.autosize = new System.Windows.Forms.Panel();
            this.tippass = new System.Windows.Forms.ToolTip(this.components);
            this.tiplog = new System.Windows.Forms.ToolTip(this.components);
            this.autosize.SuspendLayout();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.login.BackColor = System.Drawing.SystemColors.Control;
            this.login.Location = new System.Drawing.Point(330, 91);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(100, 20);
            this.login.TabIndex = 0;
            this.tiplog.SetToolTip(this.login, "-Login must contain latin lerrers and/or digits.\r\n");
            // 
            // log
            // 
            this.log.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.log.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.log.Location = new System.Drawing.Point(263, 291);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(100, 33);
            this.log.TabIndex = 2;
            this.log.Text = "Login!";
            this.log.UseVisualStyleBackColor = false;
            this.log.Click += new System.EventHandler(this.log_Click);
            // 
            // password
            // 
            this.password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.password.BackColor = System.Drawing.SystemColors.Control;
            this.password.Location = new System.Drawing.Point(328, 156);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(102, 20);
            this.password.TabIndex = 1;
            this.tippass.SetToolTip(this.password, "-The maximum password length is 14 characters.\r\n-Password must contain latin lerr" +
        "ers and/or digits.");
            // 
            // showpass
            // 
            this.showpass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.showpass.AutoSize = true;
            this.showpass.Location = new System.Drawing.Point(446, 157);
            this.showpass.Name = "showpass";
            this.showpass.Size = new System.Drawing.Size(101, 17);
            this.showpass.TabIndex = 3;
            this.showpass.Text = "Show password";
            this.showpass.UseVisualStyleBackColor = true;
            this.showpass.CheckedChanged += new System.EventHandler(this.showpass_CheckedChanged);
            // 
            // cancel
            // 
            this.cancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cancel.Location = new System.Drawing.Point(398, 291);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(100, 33);
            this.cancel.TabIndex = 2;
            this.cancel.Text = "Exit";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // Username
            // 
            this.Username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Username.AutoSize = true;
            this.Username.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Username.Location = new System.Drawing.Point(239, 90);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(85, 18);
            this.Username.TabIndex = 4;
            this.Username.Text = "Username";
            this.Username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passname
            // 
            this.passname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passname.AutoSize = true;
            this.passname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passname.Location = new System.Drawing.Point(239, 154);
            this.passname.Name = "passname";
            this.passname.Size = new System.Drawing.Size(83, 18);
            this.passname.TabIndex = 5;
            this.passname.Text = "Password";
            // 
            // autosize
            // 
            this.autosize.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.autosize.Controls.Add(this.passname);
            this.autosize.Controls.Add(this.showpass);
            this.autosize.Controls.Add(this.login);
            this.autosize.Controls.Add(this.password);
            this.autosize.Controls.Add(this.Username);
            this.autosize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.autosize.Location = new System.Drawing.Point(0, 0);
            this.autosize.Name = "autosize";
            this.autosize.Size = new System.Drawing.Size(800, 450);
            this.autosize.TabIndex = 6;           
            // 
            // tippass
            // 
            this.tippass.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tippass.ToolTipTitle = "Enter your password here";
            // 
            // tiplog
            // 
            this.tiplog.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tiplog.ToolTipTitle = "Enter your login here";
            // 
            // Init
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.log);
            this.Controls.Add(this.autosize);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Init";
            this.Text = "Initializate";
            this.autosize.ResumeLayout(false);
            this.autosize.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.Button log;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.CheckBox showpass;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label passname;
        private System.Windows.Forms.Panel autosize;
        private System.Windows.Forms.ToolTip tippass;
        private System.Windows.Forms.ToolTip tiplog;
    }
}

