using System;
using System.Collections.Generic;
using System.Text;
namespace Entities {
    class VerifyPassWord {
        public int PassWord { get; set; }
        public VerifyPassWord(int passWord) {
            PassWord = passWord;
        }
        public bool Verify() {
            if(PassWord == 2002) {
                return true;
            }
            else {
                return false;
            }
        }

    }
}
