using namespaceB; // 다른 프로젝트에 있으면 using 쓸 수 없음..
using System.Windows.Forms;
// using namespaceA; // err
/*
 basic..
- ctrl + f5 = 디버깅없이 실행
- f5: 디버그 모드 실행
 */
// PPT 1. CSharp의 GUI, 기초 다루기
namespace CSharp // namespace 이름 변경하면 에러남.
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); // 초기화
            MessageBox.Show("메세지 박스 보여주기");
            // 텍스트 박스에 메세지 출력
            textBox_print.Text = "this is \r\n multiLine \r\n TextBox!"; // 여러 줄 텍스트 출력


            // C# interactive 실행해보기
            // [검색] > [기능 검색] > 'C# 대화형' 검색
            // 콘솔창에 Console.WriteLine(""); 이용해서 콘솔창에 원하는 내용 나오는지 확인하기
            // 주의) 한글은 반복되어 나오는 특성이 있기 때문에 영어로 테스트

            // ------------- 기초 문법 (1): namespace ------------------
            // namespace의 클래스 사용해보기
            // 1. 같은 파일의 namespaceA에 접근
            namespaceA.A memberA = new namespaceA.A();
            //A memberA = new A();
            textBox_print.Text += "\r\nmemberA's varaible: " + memberA.a;

            // 2. 다른 파일의 namespaceB에 접근: 
            // namespaceB.B memberB = new namespaceB.B(); // using 없을 때도 접근 가능
            B memberB = new B(); // using 있을 때는 점 접근법 사용하지 않아도 ok
            textBox_print.Text += "\r\nmemberB's varaible: " + memberB.b + "\r\n";

            // ----------- 기초 문법 (2): 변수 ----------------------
            // 1. 자료형 특정
            int num = -100;
            uint p_num = 321; // 양수만 가능
            float f_num = 124.5213f;
            char word = 'A'; // 유니코드 16bit 문자 (한 글자)
            string name = "John"; // 유니코드 문자열
            num = int.Parse("300"); // int.Parse(문자열) >> string to integer
            name = 400.ToString(); // 숫자.ToString() >> number to string
            // 2. 자료형 특정x
            var name2 = "your name";
            var num2 = 1000;
            var one_char = '0';
            // 3. 자료형 특정하지 않았을 때 타입 확인
            textBox_print.Text += name2.GetType() + "\r\n"; // System.String
            textBox_print.Text += num2.GetType() + "\r\n"; // System.Int32
            textBox_print.Text += one_char.GetType() + "\r\n"; // System.Char
            // 4. 배열
            int[] array1 = new int[5]; // 기본 배열 선언
            int[] array2 = { 1, 2, 3, 4, 5, 6 }; // 선언과 동시에 초기화
            int[,] multiDimensionalArray1 = new int[2, 3]; // 2차원 배열 선언
            int[,] multiDimensionalArray2 = { { 1, 2, 3 }, { 4, 5, 6 } }; // 2차원 배열 선언과 동시에 초기화
            int[][] jaggedArray = new int[6][]; // 2차원 배열, [6]x[미정] 선언
            jaggedArray[0] = new int[4] { 1, 2, 3, 4 }; // 0번째에 길이 4인 배열 할당.

            // foreach 문 (배열 혹은 iterable 자료형 반복문)
            foreach(int element in array2) {
                textBox_print.Text += "number1: "+ element + "\r\n"; 
            }

            // 함수 사용해보기 (아래 친구들 모두 호출OK)
            // IdentifyAniamal("Dog");
            // IdentifyAniamal("Hamster");
            // GotoTest(2);

            // 실습1 Calculation 호출
            Calculation(17, 4, "*"); // 68 (정상계산)
            Calculation(17, 0, "/"); // 0으로 나눌 수 없어요 
            Calculation(17, 2, "kk"); // 연산자의 종류가 이상해요



        }
        

        // 함수 선언
        // switch 문 포함한 void 함수
        public void IdentifyAniamal(string animal)
        {
            switch (animal)
            {
                case "Dog":
                    textBox_print.Text = "This is a dog.";
                    break;
                case "Cat":
                    textBox_print.Text = "This is a cat.";
                    break;
                case "Bird":
                    textBox_print.Text = "This is a bird.";
                    break;
                default:
                    textBox_print.Text = "I don't know this animal~";
                    break;
            }

        }

       // goto
       // - 직접적은 점프를 해서 복잡한 흐름을 단순화할 수 있음
       // - 가독성 및 유지보수성 저하
       // - 구조적 프로그래밍 위배: goto가 구조적 흐름을 깨뜨릴 수 있다.
       // - for, if 등으로 대체될 수 있음

         public void GotoTest(int selection ) {
            
            if (selection == 0)
            {
                textBox_print.Text = "Start!!";
                goto Location1;

            }
            else if (selection == 1)
            {
                textBox_print.Text = "Start!!";
                goto Location2;
            }
            else
            {
                textBox_print.Text = "i don'k know this number";
                return; // 함수 종료 시켜 아래로 내려가지 않도록.
                // return 이 없으면 Location1, Location2, End레이블 모두 실행됨
            }
            // goto로 이동되는 레이블은 밑에 있는게 일반적
            // 이짝으로 이동되는거지 실행이 안되는게 아니다.
            Location1:
                textBox_print.Text += "Location1: ";
                goto Location2;
            Location2:
                textBox_print.Text += "Location2: ";
                goto END;
            END:
                textBox_print.Text += "길찾기 끝";           
         }

        // --------------- 실습1.  Calculation method 만들기 ---------------
        public void Calculation(int a, int b, string op) 
        {
            int result; // 계산 결과를 저장할 변수
            switch (op) {
                case "+":
                    textBox_print.Text = "결과: " + (a + b )+ "\r\n";
                    break;
                case "-":
                    textBox_print.Text = "결과: " + (a - b) + "\r\n";
                    break;
                case "*":
                    textBox_print.Text = "결과: " + (a * b) + "\r\n";
                    break;
                case "/":
                    if (b == 0) {
                        textBox_print.Text = "0으로 나눌 수 없습니다.\r\n";
                        break; 
                    }
                    textBox_print.Text = "결과: " + (a / b) + "\r\n";
                    break;
                default:
                    textBox_print.Text = "연산자의 종류가 이상해요.";
                    break;
            }

            
            

           
        }

        // 버튼더블클릭 -> 버튼에 대한 코드 자동생성
        private void button_hello_click(object sender, System.EventArgs e)
        {
            // 버튼 클릭했을 때 여기 내부 코드 실행됨
        }

        // --------------- 실습2.  Calculation method 만들기 ---------------

    }

    namespace namespaceA
    {
        public class A
        {
            public int a = 1;
            public A() { }


        }
    }

    namespace basicGrammar
    {
        public class Method
        {
            public Method() { }
            int Add(int a, int b)
            {
                return a + b;
            }

            void SayHello()
            {
                // 여기서는 textBox_print에 접근 안됨: 컨텍스트 생성되지 않음
                // textBox_print는 class Form1에서만 접근 가능
                //return ""; 뭔가를 리턴하면 에러
            }
        }
    }
}

// namespace:  
// - 비슷한 기능끼리 묶어둘 수 있음. 클래스를 포함하며, 클래스보다 더 큰 개념
// - 네임스페이스에는 클래스, 함수만 작성 가능.
// - 다른 네임스페이스에 있는 함수/클래스도 접근할 수 있음(접근제어의 종류마다 다름)
//   - using 키워드 없을 때: [네임스페이스이름].[네임스페이스멤버] : 점 접근법 사용
//   - using 키워드 있을 때: 그냥 접근할 수 있음
//   - 다른파일에 있는지, 같은 파일에 있는지는 중요하지 않다.