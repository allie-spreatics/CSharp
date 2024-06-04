using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// 구조체의 선언은 namespace 안/팍 상관없음?
struct Point
{
    public int x; public int y; public int z;
}

namespace Upgrade
{
    
    // partial class? 하나의 파일 안에만 있는 클래스가 아니고
    // 하나의 클래스가 여러 파일에 걸쳐서 정의되어 있는 class
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Point p = new Point();
            p.x = 13;
            p.y = 21;
            p.z = -4;

            string 변수 = "변수";
            textBox_print.Text = $"문자열과 {변수}를 함께 쓰고 싶을 때는 이렇게 \r\n"; // 템플릿 리터럴 같은 것? > + 기호를 쓰지 않고 더 편하게 문자열과 변수를 같이 쓰는 것 달러,
                                                                                       // 큰따옴표를 이용하고 변수 사용할 때는 중괄호 이용
            textBox_print.Text += $"point({p.x}, {p.y}, {p.z})";

            // 구조체 배열로 선언해서 사용해보기
            Point[] point = new Point[3];
            textBox_print.Text += " \r\n \r\n ---Point 구조체 <배열형태> 확인해보기--- \r\n \r\n";

            for (int i = 0; i < point.Length; i++)
            {
                point[i].x = i; point[i].y=i*i;  point[i].z = -i;
                textBox_print.Text += $"{i}번째: [x: {point[i].x}, y: {point[i].y}, z: {point[i].z}] \r\n";
            }

            Square Bob = new Square("네모네모 스펀지밥 생성");

            // *** Circle 객체 생성 후 getter 사용해보기
            Circle pizza = new Circle("pizza_hut");
            textBox_print.Text = "pizza 의 이름(1)은 " + pizza.Name+"\r\n"; 
            textBox_print.Text += "pizza 의 이름(2)은 " + pizza.privateNameGetter() + "\r\n"; 
            // 직접 Name 속성에 접근하는 것 같아 보이지만, getter 를 사용하는 것
            // 그리고 실제로는 Name이 아닌 private 로 설정되어 있는 name을 사용한다.

        }

        // 생성자와 소멸자 관련된 클래스 Square 생성
        public class Square
        {
            public Square(string Text)
            {
                MessageBox.Show(Text);
            }

            // 소멸자는 프로그램(프로세스?)이 꺼질 떄 생성됨
            // 1. 네모네모 스펀지밥 객체 Bob 이 생성
            // 2. Form1 윈폼 등장
            // 3. 윈폼에서 모든 동작 완료후 사용자가 엑스표시를 눌러서 윈폼이 꺼질 때. 소멸자 실행 -> Bob 객체 사라짐
            ~Square() // 소멸자는 접근제어없이 물결표시만 붙입니다.
            {
                MessageBox.Show("소멸..");
            }
        }

        // 속성 관련 메소드 Star
        public class Circle
        {

            // *** property ***
            // https://see-ro-e.tistory.com/115
            
            private string name;
            public string Name{ get { return name; } set {name=value; } } // get과 set?
            // 생성자
            public Circle(String circleName) {
                // *** Name 속성의 setter 사용해보기
                Name = circleName; // 자동으로 set 이후의 로직 사용하게 됨
            }
            public string privateNameGetter() {
                return name;
            }
            

        }
        // 04_ppt의 실습2
        public class Weqpon
        {
            public int attackStrength { get; set; }
            public int attackSpeed { get; set; }

            public Weqpon(int strength, int speed)
            {
                attackSpeed = speed;
                attackStrength = strength;  
            }
            public string getInfo() {
                return $"[공격력: ({attackStrength}), 공격속도: ({attackSpeed})]";
            }
        }

        // Weapon 클래스를 상속받는 Rifle, Knife 클래스 정의하기... [여기부터 진행하기!!!!!]
        private void Form1_Load(object sender, EventArgs e)
        {
            Test();
        }

        // 람다식.
        /*
         람다식이란? 메서드를 하나의 식으로 표현하는 것.(익명함수)
         - 람다식으로 메소드를 변수처럼 다루는 것이 가능?
        
         */
        void Hi() => textBox_print.Text += "hi";
        int Add(int a, int b) => a + b;

        void Test()
        {
     
        }
    }
}


