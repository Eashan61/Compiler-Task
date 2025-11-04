#include <iostream>
#include <string>
using namespace std;

int main() {

    string firstName, lastName, fullName;

    cout << "Enter Your First Name: ";
    cin >> firstName;

    cout << "Enter Your Last Name: ";
    cin >> lastName;

    fullName = firstName + " " + lastName;

    cout << "Full Name = " << fullName << endl;

    return 0;
}

