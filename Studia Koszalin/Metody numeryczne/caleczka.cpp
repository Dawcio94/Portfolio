#include<iostream>
using namespace std;

float caleczka(float m1, float m2, float m3, float m4, float min, float max, float n){
	float p=0;
	float d=(max-min)/n;
	float a=min;
	float b=min+d;
	for(int i=min;i<=n;i++){
		float y1=(m1*a*a*a)+(m2*a*a)+(m3*a)+m4;
		float y2=(m1*b*b*b)+(m2*b*b)+(m3*b)+m4;
		a=b-d;
		b=b+d;
		p=p+((y1+y2)*d/2);	
	}
	return p;
}
int main(){
	float m1,m2,m3,m4,min,max,n;
	cout<<"Podaj wartosc m1"<<endl;
	cin>>m1;
	cout<<"Podaj wartosc m2"<<endl;
	cin>>m2;
	cout<<"Podaj wartosc m3"<<endl;
	cin>>m3;
	cout<<"Podaj wartosc m4"<<endl;
	cin>>m4;
	cout<<"Podaj argument minimalny"<<endl;
	cin>>min;
	cout<<"Podaj argument maksymalny"<<endl;
	cin>>max;
	cout<<"Podaj na ile czesci chcesz podzielic dany obszar"<<endl;
	cin>>n;
	cout<<"Wynik to: "<<caleczka(m1,m2,m3,m4,min,max,n);
	
}
