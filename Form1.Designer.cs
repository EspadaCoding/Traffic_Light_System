using System.ComponentModel;

namespace Traffic_Light_System
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new Container();
            timer1 = new System.Windows.Forms.Timer(components);
            butStart = new Button();
            butStop = new Button();
            UP = new Button();
            DOWN = new Button();
            RIGHT = new Button();
            LEFT = new Button();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // butStart
            // 
            butStart.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            butStart.Location = new Point(14, 615);
            butStart.Margin = new Padding(4, 3, 4, 3);
            butStart.Name = "butStart";
            butStart.Size = new Size(88, 27);
            butStart.TabIndex = 0;
            butStart.Text = "Start";
            butStart.UseVisualStyleBackColor = true;
            butStart.Click += butStart_Click;
            // 
            // butStop
            // 
            butStop.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            butStop.Location = new Point(122, 615);
            butStop.Margin = new Padding(4, 3, 4, 3);
            butStop.Name = "butStop";
            butStop.Size = new Size(88, 27);
            butStop.TabIndex = 1;
            butStop.Text = "Stop";
            butStop.UseVisualStyleBackColor = true;
            butStop.Click += butStop_Click;
            // 
            // UP
            // 
            UP.Location = new Point(625, 615);
            UP.Name = "UP";
            UP.Size = new Size(81, 28);
            UP.TabIndex = 2;
            UP.Text = "UP";
            UP.UseVisualStyleBackColor = true;
            UP.Click += UP_Click;
            // 
            // DOWN
            // 
            DOWN.Location = new Point(712, 614);
            DOWN.Name = "DOWN";
            DOWN.Size = new Size(79, 28);
            DOWN.TabIndex = 3;
            DOWN.Text = "DOWN";
            DOWN.UseVisualStyleBackColor = true;
            DOWN.Click += DOWN_Click;
            // 
            // RIGHT
            // 
            RIGHT.Location = new Point(797, 614);
            RIGHT.Name = "RIGHT";
            RIGHT.Size = new Size(85, 28);
            RIGHT.TabIndex = 4;
            RIGHT.Text = "RIGHT";
            RIGHT.UseVisualStyleBackColor = true;
            RIGHT.Click += RIGHT_Click;
            // 
            // LEFT
            // 
            LEFT.Location = new Point(888, 615);
            LEFT.Name = "LEFT";
            LEFT.Size = new Size(75, 27);
            LEFT.TabIndex = 5;
            LEFT.Text = "LEFT";
            LEFT.UseVisualStyleBackColor = true;
            LEFT.Click += LEFT_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOliveGreen;
            ClientSize = new Size(964, 655);
            Controls.Add(LEFT);
            Controls.Add(RIGHT);
            Controls.Add(DOWN);
            Controls.Add(UP);
            Controls.Add(butStop);
            Controls.Add(butStart);
            DoubleBuffered = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Traffic Light";
            Load += Form1_Load;
            Paint += Form1_Paint;
            Resize += Form1_Resize;
            ResumeLayout(false);
        }

        #endregion

        private Button UP;
        private Button DOWN;
        private Button RIGHT;
        private Button LEFT;
    }
}