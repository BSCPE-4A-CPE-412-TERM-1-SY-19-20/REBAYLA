//972310
#include<stdio.h>
#include<conio.h>
#include<string.h>

int main()
{
    int flag=0,flag2=0,i,len;
    char str[20];
    printf("Enter String:\n");
    
    gets(str);
    len=strlen(str);
    for(i=0;i<len;i++)
    {
        if(str[i]=='a'&&str[i+1]=='a')
        {
            flag++;
        }
        if(str[i]=='b'&&str[i+1]=='b')
        {
            flag2++;
        }    
        if(flag>0&&flag2>0)
        {
            printf("\nValid");
            return 0;
        }
    }
    printf("\nInvalid");
    return 0;
}
