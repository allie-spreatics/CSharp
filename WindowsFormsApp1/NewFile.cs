using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using allie;

namespace WindowsFormsApp1
{
    // 원래 주석, ctrl k 
    // 열받으니 까 주석 ctrl /로 바꾸기: https://velog.io/@dohui/Visual-Studio-%EC%A3%BC%EC%84%9D-%EB%8B%A8%EC%B6%95%ED%82%A4-%EB%B3%80%EA%B2%BD-ctrl
    internal class NewFile
    {
        public class School
        {
            void goto_school()
            {
                allie.School school; // allie namespace에 있는 스쿨클래스 사용, using 으로 임포트해와야 외부파일의 네임스페이스 접근 가능
                school=new allie.School();
                school.do_something(); // allie namespace에 있는 School 클래스의 do_something 메소드 사용 (접근제어자 public)
            }
        }
    }
}
