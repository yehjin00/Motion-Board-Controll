using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace WindowsFormsApp6  // 제어 시퀀스 while-switch문 사용, 객체지향 프로그램을 더 공부해야겠다....
                            // 계속 쓰레기값이 들어가있는데 상대좌표로 어떻게 그리지? sleep없이 어떻게 하지?
{
    public partial class Form1 : Form
    {

        Socket udpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);  // 선언, 초기화
        EndPoint _remoteEP;
        bool _state=true;  // Thread 함수 while문 상태
        string _axisValue; // 선택한 축 받아오기
        
        public Form1()
        {
            InitializeComponent();
            this.button_send.Enabled = false;   // 폼을 열었을때 버튼 누르지못하게 하기
            this.button_rectangle.Enabled = false;
            this.button_stop.Enabled = false;
            this.button1_Home.Enabled = false;
            this.button1_Set_Zero.Enabled = false;
            this.textbox_ip.Text = "192.168.10.5";  // 폼을 열었을때 텍스트 박스에 값이 들어가있도록 하기
            this.textbox_port.Text = "4000";
            this.textBox4_start_velocity.Text = "100";
            this.textBox5_end_velocity.Text = "50000";
            this.textBox6_acceleration.Text = "100000";
            this.textBox7_deceleration.Text = "100000";
            this.textBox8_jerk.Text = "100";  // jerk : 홱 움직이다.( 가속도의 변화량 )

        }

        private void check_Click(object sender, EventArgs e)  // 확인 버튼
        {
            string ipaddress = string.Empty;
            ipaddress = textbox_ip.Text;  // ip 번호 입력
            IPAddress ipin = IPAddress.Parse(ipaddress);  // 문자열 ip주소를 숫자로 변환하기

            string portn = string.Empty;
            portn = textbox_port.Text;  // 포트 번호 입력
            int portin = Convert.ToInt32(portn);  // 문자열 포트 번호를 int형으로 변환하기

            if ((Convert.ToString(ipin) == "192.168.10.5") && (portin == 4000)) // ip주소와 port번호가 원하는 것과 일치하면
            {
                before.Text = "ok!";
                this.button_stop.Enabled = true;  // 버튼 활성화
                this.button1_Home.Enabled = true;
                this.button1_Set_Zero.Enabled = true;
                this.timer1.Start();  // 현재위치 받아오기
                _remoteEP = new IPEndPoint(ipin, portin);  // ip와 port번호가 유효하면 remoteEP에 저장
            }
            else
            {
                before.Text = "false..";
            }
        }

        private void radioButton_X_axis(object sender, EventArgs e)  // x 축 선택
        {
            _axisValue = "0";
            this.button_send.Enabled = true; // 축을 선택하면 '전송' 버튼 활성화
        }

        private void radioButton_Y_axis(object sender, EventArgs e)  // y 축 선택
        {
            _axisValue = "1";
            this.button_send.Enabled = true;  
        }

        private void button_send_Click(object sender, EventArgs e) // 마우스로 클릭하면 '전송'버튼이 눌린다.
        {
            // 전송할 값
            string positionValue = string.Empty;
            positionValue = textBox3_position.Text;
            string startvelocityValue = string.Empty;
            startvelocityValue = textBox4_start_velocity.Text;
            string endvelocityValue = string.Empty;
            endvelocityValue = textBox5_end_velocity.Text;
            string accelerationValue = string.Empty;
            accelerationValue = textBox6_acceleration.Text;
            string decelerationValue = string.Empty;
            decelerationValue = textBox7_deceleration.Text;
            string jerkValue = string.Empty;
            jerkValue = textBox8_jerk.Text;

            // 0은 x축, 1은 y축
            string sendMsg = String.Format("U[{0}, 5] ={1}, U[{0}, 6] ={2}, U[{0}, 7] ={3}, U[{0}, 8] ={4}, U[{0}, 9] ={5}, U[{0}, 10] ={6}, M[{0}] = 7", _axisValue, positionValue, startvelocityValue, endvelocityValue, accelerationValue, decelerationValue, jerkValue);
            send(sendMsg);  // 받은 값을 send함수의 인수로 대입

        }

        private void timer1_Tick(object sender, EventArgs e)  // 모터의 위치를 매 시간 받아오기
        {
            string str_x = string.Empty;
            str_x = String.Format("U[0,3]=0,M[0]=5,U[0,4]");
            xcurrent_position_print(str_x);

            string str_y = string.Empty;
            str_y = String.Format("U[1,3]=0,M[1]=5,U[1,4]");
            ycurrent_position_print(str_y);
        }

        private void xcurrent_position_print(string str)  // x 현재위치 출력
        {
            byte[] sendBuffer = Encoding.UTF8.GetBytes(str);
            udpSocket.SendTo(sendBuffer, _remoteEP);  // sendBuffer에 받아온것을 remoteEP에 보내기
            byte[] receiveBuffer = new byte[512];
            int receivedSize = udpSocket.ReceiveFrom(receiveBuffer, ref _remoteEP); // remoteEP에 있는 것을 receiveBuffer로 받아오기
            string receivedMsg = Encoding.UTF8.GetString(receiveBuffer);
            string[] splittedMsg = receivedMsg.Split(new char[] { ':', ',', ' ' });  // 원하는 데이터만 보기위해 데이터 자르기
            textBox2.Text = splittedMsg[6];  // 6번째 글자가 위치를 의미한다.
        }

        private void ycurrent_position_print(string str_y)  // y 현재위치 출력
        {
            byte[] sendBuffer_y = Encoding.UTF8.GetBytes(str_y);
            udpSocket.SendTo(sendBuffer_y, _remoteEP);  // sendBuffer에 받아온것을 remoteEP에 보내기
            byte[] receiveBuffer_y = new byte[512];
            int receivedSize_y = udpSocket.ReceiveFrom(receiveBuffer_y, ref _remoteEP); // remoteEP에 있는 것을 receiveBuffer로 받아오기
            string receivedMsg_y = Encoding.UTF8.GetString(receiveBuffer_y);
            string[] splittedMsg_y = receivedMsg_y.Split(new char[] { ':', ',', ' ' });
            textBox1.Text = splittedMsg_y[6];
        }

        private void rectangle_draw(string axis, string positionValue) // 사각형 그리기위해 축, 위치 설정하기
        {
            _axisValue = axis;  // 전역변수에 지역변수 대입하기
            string sendMsg = String.Format("U[{0}, 5] ={1}, U[{0}, 6] =100, U[{0}, 7] =50000, U[{0}, 8] =100000, U[{0}, 9] =100000, U[{0}, 10] =100, M[{0}] = 7", _axisValue, positionValue);
            send(sendMsg);
            this.timer1.Start();
        } 

        private void button_rectangle_Click(object sender, EventArgs e)  // 사각형 그리기 버튼
        {
            _state = true; // while문 시작
            Thread myThread = new Thread(rectangle_loop);  // Thread 함수 시작
            myThread.Start(); // 작업스레드 만들어서 while문 만들기, 스레드 죽이기 : while문 돌고있으면 abort쓰지말기 그냥 false하면 스레드 나감. 스레드함수를 탈출해서 종료시키면된다.
        }  

        private void button_stop_Click(object sender, EventArgs e)  // stop 버튼
        {
            _state = false;  // while문을 빠져나와라
            stop("0");  // x축을 멈춰라
            stop("1");  // y축을 멈춰라
        }

        private void stop(string axisValue)  // stop 명령
        {
            string str = string.Empty;
            str = String.Format("U[{0},11]=0", axisValue);
            str = String.Format("M[{0}]=10", axisValue);
            send(str);
            
        }

        private void send(string str)  // sendBuffer에 받아온것을 remoteEP에 보내기
        {
            byte[] sendBuffer = Encoding.UTF8.GetBytes(str);
            udpSocket.SendTo(sendBuffer, _remoteEP);  // sendBuffer에 받아온것을 remoteEP에 보내기
            byte[] receiveBuffer = new byte[512];
            int receivedSize = udpSocket.ReceiveFrom(receiveBuffer, ref _remoteEP); // remoteEP에 있는 것을 receiveBuffer로 받아오기
        }

        private void rectangle_loop()  // 사각형을 그리는 함수
        {
            string x1 = "100000";  // 정사각형 그리기
            string y1 = "100000";

            string x2 = "0";
            string y2 = "0";
            
            int position_case = 0;
            while (_state)
            {
                switch (position_case)
                {
                    case 0:  
                        rectangle_draw("1", y1); // 사각형 그리기
                        position_case = 1;
                        Thread.Sleep(3000);
                        if (y1 == textBox1.Text) // 위치 확인하고 case 변경
                        {
                            position_case = 1;  // 위치가 일치하면 사각형 마저 그리기
                        }
                        else
                        {
                            position_case = 0;  // 위치가 일치할때까지 이동하기
                        }
                        break;
                    case 1:
                        rectangle_draw("0", x1);
                        position_case = 3;
                        Thread.Sleep(3000);
                        if (x1 == textBox2.Text)
                        {
                            position_case = 2;
                        }
                        else
                        {
                            position_case = 1;
                        }
                        break;
                    case 2:
                        rectangle_draw("1", y2);
                        position_case = 5;
                        Thread.Sleep(3000);
                        if (y2 == textBox1.Text)
                        {
                            position_case = 3;
                        }
                        else
                        {
                            position_case = 2;
                        }
                        break;
                    case 3:
                        rectangle_draw("0", x2);
                        position_case = 7;
                        Thread.Sleep(3000);
                        if (x2 == textBox2.Text)
                        {
                            position_case = 0;
                        }
                        else
                        {
                            position_case = 3;
                        }
                        break;
                }
            }
        }

        private void button1_Home_Click(object sender, EventArgs e)  // Home 버튼
        {
            Thread myThread = new Thread(Home);  // Thread 함수 시작
            myThread.Start();
            this.button_rectangle.Enabled = true;  // 위치 초기화가 된 후 사각형 그리기 가능하게 하기
        }

        private void Home()  // Home으로 가라는 명령
        {
            Home_axis("0");  // Home으로 갈 축 선택
            Home_axis("1");
            Thread.Sleep(7000);
            stop("0");
            stop("1");

        }

        private void Home_axis(string axisValue)  // Home으로 갈 축 선택
        {
            string str = string.Empty;
            str = string.Format("U[{0},118]=0", axisValue);
            str = string.Format("M[{0}]=17", axisValue);
            send(str);
        }

        private void button1_Set_Zero_Click(object sender, EventArgs e)  // 위치 초기화 버튼
        {
            string str = string.Empty;
            str = string.Format("U[0,4]=0,M[0]=6,U[1,4]=0,M[1]=6");  // 위치 초기화 명령
            send(str);
            // 두 축의 현재위치를 0으로 만들어주고 그 0으로 위치값을 설정한다.
        }

        // 버튼 이벤트
        private void textBox3_position_TextChanged(object sender, KeyEventArgs e)  // position 텍스트박스에서 엔터키를 누르면 '전송' 버튼이 눌린다.
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_send_Click(sender, e);
            }
        }

        private void connect_Click(object sender, KeyEventArgs e)  // '전송' 버튼이 활성화됐을때 엔터키를 누르면 '전송'버튼이 눌린다.
        {
            if (e.KeyCode == Keys.Enter)
            {
                connect_Click(sender, e);
            }
        }

    }
}