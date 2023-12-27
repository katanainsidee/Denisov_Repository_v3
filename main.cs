#include <iostream> 
#include <string> 
using namespace std; 
int product(int x, int n) { 
    int res = 1; 
    string x_str = to_string(x); 
    for (int i = 0; i<n;++i){ 
        res*=x_str[i] -'0'; 
    } 
    return res; 
} 