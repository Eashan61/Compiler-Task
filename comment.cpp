#include <iostream>
using namespace std;

int main() {
    string input;
    cout << "Enter something: ";

    getline(cin,input);

    if(input.find("//") ==0){

     cout << "bodda ibe single line comment! "<<endl;
    }else if(input.find("/*")!=string::npos && input.find("*/")!=string::npos){

    cout << "bodda ibe multi line comment! "<<endl;

    }else{
    cout<<"bodda ibe no comment"<<endl;
    }

    return 0;
}
