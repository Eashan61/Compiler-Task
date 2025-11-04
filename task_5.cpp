#include <iostream>
using namespace std;

int main() {
    int num;

    cout<<"Enter the number of array elements: ";

    cin>>num;

    int arr[num];
    int total = 0;

    cout<<"Enter "<< num << " Numbers:"<<endl;

    for(int i =0;i<num; i++){
        cin>>arr[i];
        total = total + arr[i];

    }

    double average = (double)total/num;

    cout<<"Total Average =" <<average;


    return 0;
}

