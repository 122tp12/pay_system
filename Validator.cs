using System;

namespace MiniBank {

	public class Validor {

		// Валідація баланса, різних цифр, тощо...

		public static bool ValidateSum(string str) {

			try {

				int temp = Convert.ToInt32(str);

			}

			catch {

				return false;

			}

			return true;


		}

		// Валідація довжини пароля...

		public static bool ValidatePasswordLength(string str) {

			if(str.Length >= 8 && str.Length <= 24) {

				return true;

			}

			else {

				return false;

			}

		}

		// Валідація символів пароля...

		public static bool ValidatePasswordSymbols(string str) {
		
			foreach(char a in str){

				if(Convert.ToInt32(a) >= 32 && Convert.ToInt32(a) <= 90 || Convert.ToInt32(a) >= 97 && Convert.ToInt32(a) <= 122) {



				}

				else {

					return false;

				}

			}

			return true;

		} 

		// Валідація входу(паролю)...

		public static bool ValidatePasswords(string RealPassword, string Password) {

			if(RealPassword == Password) {

				return true;

			}

			else {

				return false;

			}

		}

		// Валідація входу(логіна)...

		public static bool ValidateLogin(string RealEmail, string RealNumber, string Login) {

			if(RealEmail == Login || RealNumber == Login) {

				return true;

			}

			else {

				return false;

			}

		}

		// Валідація пошти...

		public static bool ValidateEmail(string str) {

			bool result = true;

			int count = 0;

			for(int i = 0; i < str.Length; i++) {

				char a = str[i];

				if(a >= 'a' && a <='z' || a>='0' && a <='9' || a == '-' || a == '.' || a == '@') {

					if(a == '-' || a == '.' || a == '@') {

						if(str[i + 1] == '-' || str[i + 1] == '.' || str[i + 1] == '@') {

							result = false;

						}

					}

				}

				else {

					result = false;

				}

				if(a == '@') {

					count++;

				}

			}

			if(count != 1) {

				result = false;

			}

			if(result == true) {

				return true;

			}

			else {

				return false;

			}

		}

	}

}