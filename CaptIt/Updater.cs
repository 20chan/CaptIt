using System;
using System.Net;

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

            //솔루션 1. 서버에 소켓으로 연결 후 서버 내 프로그램에서 SQL 쿼리 따기
            //솔루션 2. 드박이나 블로그같은 곳에 파싱용으로 업로드


            //솔루션 2가 구현은 쉬운데 관리, 유지보수 어려움.
            //반면 솔루션 1은 구현은 어려운데 유지보수는 편하고 빠른 디비편집 가능.
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
            throw new NotImplementedException();
        }

        private void Download(string path, string url)
        {

        }
    }
}
