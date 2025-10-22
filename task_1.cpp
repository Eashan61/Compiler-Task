#include <iostream>
using namespace std;

int main() {
    string s;
    cout << "Enter something: ";
    cin >> s;

    bool isNumeric = true;

    for (int i = 0; i < s.length(); i++) {
        if (s[i] < '0' || s[i] > '9') {
            isNumeric = false;
            break;
        }
    }

    if (isNumeric)
        cout << "It is a numeric constant." << endl;
    else
        cout << "It is NOT a numeric constant." << endl;

    return 0;
}
