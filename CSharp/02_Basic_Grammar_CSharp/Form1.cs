using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; // using 을 이용하여 namespace 가져오기

// Form1.cs 코드 살펴보기
namespace _02_Basic_Grammar_CSharp 
    // 프로그램의 namespace,
    // - 프로젝트의 이름과 같은 네임스페이스가 한 개는 존재한다.
{
    // - 파일 이름과 같은 클래스가 적어도 하나는 존재
    public partial class Form1 : Form
    /* 
     Form클래스를 상속하는 Form1클래스,
     System.Windows.Forms namespace 내부의 Form 클래스를 상속받는 것으로 생각됨
     접근제어자: public
     partial class*/

    // [namespace 에는 변수 선언 불가능]
    // 변수 선언은 함수 내부 혹은 클래스 내부에
    {
        public Form1()
        // Form1 클래스의 생성자
        {
            InitializeComponent(); // 윈폼 초기화를 위한 함수
            // Console.WriteLine("where is my text... ");
            
        }
    }
}
