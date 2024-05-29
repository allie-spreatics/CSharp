using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 using namespaceB; // 다른 프로젝트에 있으면 using 쓸 수 없음..
using namespaceA;
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
            {
                int a = 10;
            }

            textBox_print.Text = a.ToString();

            // C# interactive 실행해보기
            // [검색] > [기능 검색] > 'C# 대화형' 검색
            // 콘솔창에 Console.WriteLine(""); 이용해서 콘솔창에 원하는 내용 나오는지 확인하기
            // 주의) 한글은 반복되어 나오는 특성이 있기 때문에 영어로 테스트

            // ------------- 기초 문법 (1): namespace ------------------
            // namespace의 클래스 사용해보기
            // 1. 같은 파일의 namespaceA에 접근
            // namespaceA.A memberA = new namespaceA.A();
            A memberA = new A();
            textBox_print.Text += "\r\nmemberA's varaible: " + memberA.a;

            // 2. 다른 파일의 namespaceB에 접근: 
            // namespaceB.B memberB = new namespaceB.B(); // using 없을 때도 접근 가능
            B memberB = new B(); // using 있을 때는 점 접근법 사용하지 않아도 ok
            textBox_print.Text+= "\r\nmemberB's varaible: " + memberB.b;

            // ----------- 기초 문법 (2): 변수 ----------------------
            // 1. 자료형 특정
            int num = -100;
            uint p_num = 321; // 양수만 가능
            float f_num = 124.5213f;
            char word = 'A'; // 유니코드 16bit 문자 (한 글자)
            string name = "John"; // 유니코드 문자열

            // 2. 자료형 특정x
            var name2 = "your name";
            var num2 = 1000;
            var one_char = '0';
            // 3. 자료형 특정하지 않았을 때 타입 확인
            // 4. 배열


        }
    }
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
    public class Variable
    {
        public Variable() {
            var name = "allie";
            var num = 1000;
            var one_char = 'A';

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