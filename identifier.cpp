
#include <iostream>
#include <cctype>
using namespace std;

int main() {
    string input;
    cout << "Enter something: ";

    cin>>input;

    if(isalpha(input[0])|| input[0] =='_') {
        bool valid = true;

        for(int i=1; i< input.length(); i++){
            if(!isalnum(input[i]) && input[i] != '_') {
                valid = false;
                break;
            }
        }

        if (valid) {
            cout<<input<<"This is a valid identifier!"<<endl;

        }else{
            cout<<input<<"This is a not valid identifier!"<<endl;
        }

    }

    else{
            cout<<input<<"This is a not valid identifier!"<<endl;
        }
    return 0;
}
