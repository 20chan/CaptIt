using System;
using Hook;
namespace CaptIt
{
    public class HotKeyManager
    {
        private KeyboardHook _hook;
        public HotKeyManager()
        {
            _hook = new KeyboardHook();
            //여기서 hook에서 이벤트를 받는데 Down 이벤트만 연속으로 받으면 두번째부터는 무시하게끔 KeyboardHook 라이브러리 내에서 살짝 수정해야 할듯.
        }
    }
}
