#include <iostream> 
#include <string> 
using namespace std; 
int sum_digits(int x) { 
    std::string new_num = std::to_string(x); 
    int zxc = 0; 
    while (x != 0) { 
        zxc +=x%10; 
        x/=10; 
    } 
    return zxc; 
} 