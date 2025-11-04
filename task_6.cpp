#include <iostream>
using namespace std;

int main() {
    int num;

    cout<<"Enter the number of array elements: ";

    cin>>num;

    int arr[num];



    cout<<"Enter "<< num << " Numbers:"<<endl;

    for(int i = 0; i<num;i++){
        cin>>arr[i];
    }

    int min = arr[0];
    int max = arr[0];


    for(int i =1;i<num; i++){
        if(arr[i]<min)
            min = arr[i];
        if(arr[i]>max)
            max = arr[i];

    }



    cout<<"Max =" <<max<<endl;

    cout<<"Min =" <<min<<endl;


    return 0;
}


