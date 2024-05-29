using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        }
    }
}
