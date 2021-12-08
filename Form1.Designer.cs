
namespace WindowsFormsApp6
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button_send = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.connect = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textbox_ip = new System.Windows.Forms.TextBox();
            this.textbox_port = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3_position = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4_start_velocity = new System.Windows.Forms.TextBox();
            this.textBox5_end_velocity = new System.Windows.Forms.TextBox();
            this.textBox6_acceleration = new System.Windows.Forms.TextBox();
            this.textBox7_deceleration = new System.Windows.Forms.TextBox();
            this.textBox8_jerk = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button_rectangle = new System.Windows.Forms.Button();
            this.button_stop = new System.Windows.Forms.Button();
            this.radioButton_X = new System.Windows.Forms.RadioButton();
            this.radioButton_Y = new System.Windows.Forms.RadioButton();
            this.before = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1_Home = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1_Set_Zero = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_send
            // 
            this.button_send.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_send.Location = new System.Drawing.Point(124, 237);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(100, 30);
            this.button_send.TabIndex = 11;
            this.button_send.Text = "전송";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.button_send_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(10, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = " X축 현재 위치";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(11, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "연결할 IP주소 :";
            // 
            // connect
            // 
            this.connect.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.connect.Location = new System.Drawing.Point(569, 33);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(48, 25);
            this.connect.TabIndex = 0;
            this.connect.Text = "확인";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.check_Click);
            this.connect.KeyDown += new System.Windows.Forms.KeyEventHandler(this.connect_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(363, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "포트번호 :";
            // 
            // textbox_ip
            // 
            this.textbox_ip.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textbox_ip.Location = new System.Drawing.Point(127, 33);
            this.textbox_ip.Name = "textbox_ip";
            this.textbox_ip.Size = new System.Drawing.Size(203, 25);
            this.textbox_ip.TabIndex = 7;
            // 
            // textbox_port
            // 
            this.textbox_port.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textbox_port.Location = new System.Drawing.Point(444, 30);
            this.textbox_port.Name = "textbox_port";
            this.textbox_port.Size = new System.Drawing.Size(100, 25);
            this.textbox_port.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox2.Location = new System.Drawing.Point(13, 62);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(118, 25);
            this.textBox2.TabIndex = 13;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(51, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "position";
            // 
            // textBox3_position
            // 
            this.textBox3_position.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox3_position.Location = new System.Drawing.Point(124, 37);
            this.textBox3_position.Name = "textBox3_position";
            this.textBox3_position.Size = new System.Drawing.Size(100, 25);
            this.textBox3_position.TabIndex = 1;
            this.textBox3_position.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox3_position_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(23, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "start velocity";
            // 
            // textBox4_start_velocity
            // 
            this.textBox4_start_velocity.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox4_start_velocity.Location = new System.Drawing.Point(124, 68);
            this.textBox4_start_velocity.Name = "textBox4_start_velocity";
            this.textBox4_start_velocity.Size = new System.Drawing.Size(100, 25);
            this.textBox4_start_velocity.TabIndex = 6;
            // 
            // textBox5_end_velocity
            // 
            this.textBox5_end_velocity.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox5_end_velocity.Location = new System.Drawing.Point(124, 99);
            this.textBox5_end_velocity.Name = "textBox5_end_velocity";
            this.textBox5_end_velocity.Size = new System.Drawing.Size(100, 25);
            this.textBox5_end_velocity.TabIndex = 7;
            // 
            // textBox6_acceleration
            // 
            this.textBox6_acceleration.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox6_acceleration.Location = new System.Drawing.Point(124, 130);
            this.textBox6_acceleration.Name = "textBox6_acceleration";
            this.textBox6_acceleration.Size = new System.Drawing.Size(100, 25);
            this.textBox6_acceleration.TabIndex = 8;
            // 
            // textBox7_deceleration
            // 
            this.textBox7_deceleration.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox7_deceleration.Location = new System.Drawing.Point(124, 161);
            this.textBox7_deceleration.Name = "textBox7_deceleration";
            this.textBox7_deceleration.Size = new System.Drawing.Size(100, 25);
            this.textBox7_deceleration.TabIndex = 9;
            // 
            // textBox8_jerk
            // 
            this.textBox8_jerk.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox8_jerk.Location = new System.Drawing.Point(124, 192);
            this.textBox8_jerk.Name = "textBox8_jerk";
            this.textBox8_jerk.Size = new System.Drawing.Size(100, 25);
            this.textBox8_jerk.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(24, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 15);
            this.label7.TabIndex = 25;
            this.label7.Text = "end velocity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(24, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 15);
            this.label8.TabIndex = 26;
            this.label8.Text = "acceleration";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(24, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 15);
            this.label9.TabIndex = 27;
            this.label9.Text = "deceleration";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(81, 195);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 15);
            this.label10.TabIndex = 28;
            this.label10.Text = "jerk";
            // 
            // button_rectangle
            // 
            this.button_rectangle.Location = new System.Drawing.Point(496, 319);
            this.button_rectangle.Name = "button_rectangle";
            this.button_rectangle.Size = new System.Drawing.Size(126, 31);
            this.button_rectangle.TabIndex = 12;
            this.button_rectangle.Text = "사각형그리기";
            this.button_rectangle.UseVisualStyleBackColor = true;
            this.button_rectangle.Click += new System.EventHandler(this.button_rectangle_Click);
            this.button_rectangle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button_rectangle_Click);
            // 
            // button_stop
            // 
            this.button_stop.Location = new System.Drawing.Point(665, 319);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(66, 31);
            this.button_stop.TabIndex = 13;
            this.button_stop.Text = "Stop";
            this.button_stop.UseVisualStyleBackColor = true;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // radioButton_X
            // 
            this.radioButton_X.AutoSize = true;
            this.radioButton_X.BackColor = System.Drawing.SystemColors.Control;
            this.radioButton_X.CheckAlign = System.Drawing.ContentAlignment.BottomRight;
            this.radioButton_X.Cursor = System.Windows.Forms.Cursors.Default;
            this.radioButton_X.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton_X.Location = new System.Drawing.Point(6, 38);
            this.radioButton_X.Name = "radioButton_X";
            this.radioButton_X.Size = new System.Drawing.Size(37, 19);
            this.radioButton_X.TabIndex = 3;
            this.radioButton_X.Text = "X";
            this.radioButton_X.UseVisualStyleBackColor = false;
            this.radioButton_X.CheckedChanged += new System.EventHandler(this.radioButton_X_axis);
            // 
            // radioButton_Y
            // 
            this.radioButton_Y.AutoSize = true;
            this.radioButton_Y.BackColor = System.Drawing.SystemColors.Control;
            this.radioButton_Y.CheckAlign = System.Drawing.ContentAlignment.BottomRight;
            this.radioButton_Y.Cursor = System.Windows.Forms.Cursors.Default;
            this.radioButton_Y.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton_Y.Location = new System.Drawing.Point(62, 38);
            this.radioButton_Y.Name = "radioButton_Y";
            this.radioButton_Y.Size = new System.Drawing.Size(36, 19);
            this.radioButton_Y.TabIndex = 4;
            this.radioButton_Y.Text = "Y";
            this.radioButton_Y.UseVisualStyleBackColor = false;
            this.radioButton_Y.CheckedChanged += new System.EventHandler(this.radioButton_Y_axis);
            // 
            // before
            // 
            this.before.AutoSize = true;
            this.before.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.before.Location = new System.Drawing.Point(642, 43);
            this.before.Name = "before";
            this.before.Size = new System.Drawing.Size(22, 15);
            this.before.TabIndex = 39;
            this.before.Text = "...";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(10, 110);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 15);
            this.label12.TabIndex = 40;
            this.label12.Text = "Y축 현재 위치";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1.Location = new System.Drawing.Point(13, 133);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(118, 25);
            this.textBox1.TabIndex = 41;
            // 
            // button1_Home
            // 
            this.button1_Home.Location = new System.Drawing.Point(52, 194);
            this.button1_Home.Name = "button1_Home";
            this.button1_Home.Size = new System.Drawing.Size(69, 32);
            this.button1_Home.TabIndex = 42;
            this.button1_Home.Text = "Home";
            this.button1_Home.UseVisualStyleBackColor = true;
            this.button1_Home.Click += new System.EventHandler(this.button1_Home_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textbox_port);
            this.groupBox1.Controls.Add(this.textbox_ip);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.connect);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.before);
            this.groupBox1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(52, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(719, 77);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "IP 주소 입력";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton_Y);
            this.groupBox2.Controls.Add(this.radioButton_X);
            this.groupBox2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(52, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(116, 70);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Axis";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.textBox8_jerk);
            this.groupBox3.Controls.Add(this.textBox7_deceleration);
            this.groupBox3.Controls.Add(this.textBox6_acceleration);
            this.groupBox3.Controls.Add(this.textBox5_end_velocity);
            this.groupBox3.Controls.Add(this.textBox4_start_velocity);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.textBox3_position);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.button_send);
            this.groupBox3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox3.Location = new System.Drawing.Point(198, 107);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(248, 284);
            this.groupBox3.TabIndex = 45;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Set Values";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.textBox2);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox4.Location = new System.Drawing.Point(496, 107);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(151, 178);
            this.groupBox4.TabIndex = 46;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Position";
            // 
            // button1_Set_Zero
            // 
            this.button1_Set_Zero.Location = new System.Drawing.Point(53, 240);
            this.button1_Set_Zero.Name = "button1_Set_Zero";
            this.button1_Set_Zero.Size = new System.Drawing.Size(79, 45);
            this.button1_Set_Zero.TabIndex = 47;
            this.button1_Set_Zero.Text = "Set Zero";
            this.button1_Set_Zero.UseVisualStyleBackColor = true;
            this.button1_Set_Zero.Click += new System.EventHandler(this.button1_Set_Zero_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1_Set_Zero);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1_Home);
            this.Controls.Add(this.button_stop);
            this.Controls.Add(this.button_rectangle);
            this.Name = "Form1";
            this.Text = "모션보드 제어";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textbox_ip;
        private System.Windows.Forms.TextBox textbox_port;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3_position;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4_start_velocity;
        private System.Windows.Forms.TextBox textBox5_end_velocity;
        private System.Windows.Forms.TextBox textBox6_acceleration;
        private System.Windows.Forms.TextBox textBox7_deceleration;
        private System.Windows.Forms.TextBox textBox8_jerk;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button_rectangle;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.RadioButton radioButton_X;
        private System.Windows.Forms.RadioButton radioButton_Y;
        private System.Windows.Forms.Label before;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1_Home;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button1_Set_Zero;
    }
}

