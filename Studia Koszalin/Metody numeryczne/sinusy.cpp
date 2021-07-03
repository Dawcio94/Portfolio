#include<iostream>
#include<math.h>
#include<conio.h>
#include<fstream>

using namespace std;


double silnia(int n)
{
  double silnia = 1;
  for (int i=2; i<n+1; i++)
    silnia = silnia*i;
  return silnia;
}

double cosin(double x){
	double y;
	y=cos(x);
	return y;
}

double cosinus(double x, int n, int i=1){
	double y=1;
	if(n>0){
	for(int i=1; i<n; i++){
		if(i%2==0){
		y=y+(pow(x,(i*2)))/(silnia(i*2));	
		}
		else{
		y=y-(pow(x,(i*2)))/(silnia(i*2));
	}};
	return y;
}
else {
	return 1;
}}

double cosinusek(double x, int n, int i=1)
{
	
	if(n>0){
	
		if(i%2==0){
			return (-1)*pow(x, (i-1) * 2) / silnia((i-1) * 2) + cosinusek(x, n - 1, i + 1);
		}
		else{
			return pow(x, (i-1) * 2) / silnia((i-1) * 2) + cosinusek(x, n - 1, i + 1);
		}
	}
	else{
			return 0;
	}
}

double kombinacja(int n){
	return pow(-1,n)/silnia(2*n);
}

double coshor(double x,int n){
	double y;
	double z=kombinacja(n)*pow(x,2);
	
	for(int i=n-1;i>1;i--){
	z=(z+kombinacja(i))*pow(x,2);
	}
	y=1+(((-1/silnia(2))+z)*pow(x,2));			 
		return y;
		}			
int main(){
	double x;
	int n;
	fstream dane;
	dane.open("Dane.txt", ios::out | ios::in);
	if(dane.good()== true){
		cout<< "Uzyskano dostep"<<endl;
	dane >>x>>n;
		cout<<"Wszystko w pliku dane.txt";
			dane << "any x by³ równy: "<<x<<endl;
			dane << "Podana ilosc elementow by³a równa: "<<n<<endl;
			dane << "Wynik z gotowej funkcji to: "<<cosin(x)<<endl;
			dane << "Wynik iteracyjnie to: "<<cosinus(x, n)<<endl;
			dane << "Wynik rekurencyjnie to: "<<cosinusek(x, n)<<endl;
			dane << "Wynik schematem Hornera to: "<<coshor(x,n)<<endl;
					dane.close();
	}
	else
	{
		cout<<"Brak dostepu"<<endl;
	}
	return 0;
}
