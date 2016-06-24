using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaptIt
{
    public class Updater
    {
        public Updater()
        {

        }

        public string GetVersion()
        {
            //TODO: 서버에 소켓으로 연결 후 버젼 받기. 서버는 SQL 쿼리로 가져옴.
            throw new NotImplementedException();
        }

        public void DeletePreviousVersion()
        {
            //이 메서드는 이전 버젼의 프로그램이 업데이트 된 후, 실행되었을 때 이전 버젼의 프로그램을 삭제.
        }

        public void Update()
        {
            //업데이트 프로그램을 서버로부터 다운로드.
            //지금 이 프로그램을 종료하고 업데이트 프로그램을 실행. 그리고 업데이트 프로그램은 DeletePreviousVersion을 실행하도록 매개변수를 줌.
            //Program.cs 에서 매개변수를 받아서 업데이트 된 버젼인지를 확인.
        }
    }
}
