#include <iostream>

using namespace std;

bool opCheck(string val) {
    if (val == "+") {
        return true;
    }
    else if (val == "-") {
        return true;
    }
    else if (val == "*") {
        return true;
    }
    else if (val == "/") {
        return true;
    }
    else if (val == "%") {
        return true;
    }
    else {
        return false;
    }
}

int main() {
    string input;
    cout << "Enter an operator: ";
    cin >> input;

    if (opCheck(input))
        cout << "It is a valid operator." << endl;
    else
        cout << "It is not a valid operator." << endl;

    return 0;
}
