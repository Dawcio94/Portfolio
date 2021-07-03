#include<iostream>
#include<math.h>

using namespace std;
double determ(double a[10][10],int n) {
  double det=0, temp[10][10];
  int p, h, k, i, j;
  if(n==1) {
    return a[0][0];
  } else if(n==2) {
    det=(a[0][0]*a[1][1]-a[0][1]*a[1][0]);
    return det;
  } else {
    for(p=0;p<n;p++) {
      h = 0;
      k = 0;
      for(i=1;i<n;i++) {
        for( j=0;j<n;j++) {
          if(j==p) {
            continue;
          }
          temp[h][k] = a[i][j];
          k++;
          if(k==n-1) {
            h++;
            k = 0;
          }
        }
      }
      det=det+a[0][p]*pow(-1,p)*determ(temp,n-1);
    }
    return det;
  }
}

int main()
{
	double taba[10][10],tabx[10],tabb[10],tabd[10][10];
	int n;
	cout<<"Podaj rozmiar macierzy"<<endl;
	cin>>n;
	for(int i=0;i<n;i++)
	{
			for(int j=0;j<n;j++)
			{
				cout<<"Podaj wartosc elementu macierzy A o indeksie ["<<i+1<<"]["<<j+1<<"]"<<endl;
				cin>>taba[i][j];
			}
	}
	
	cout<<"Macierz A:";
	
	for(int i=0;i<n;i++)
	{
		cout<<endl;
			for(int j=0;j<n;j++)
			{
			cout<<taba[i][j]<<" ";
			}
	}
	
	cout<<endl;
	
	if (determ(taba,n)<1)
	{
		for (int i=0;i<n;i++)
		{
			for (int j=0;j<n;j++)
			{
				if (i==j)
				{
					tabd[i][j]=taba[i][j]-1;
				}
				else
				{
					tabd[i][j]=taba[i][j];
				}
			}
		}
		
		
	for(int j=0;j<n;j++)
	{
		cout<<"Podaj wartosci elementu wektora wyrazow wolnych o numerze ["<<j+1<<"]"<<endl;
		cin>>tabb[j];
	}
	
	cout<<"Wektor wyrazow wolnych:"<<endl;
	
	for(int j=0;j<n;j++)
	{
		cout<<tabb[j]<<endl;
	}
	
	for(int i=0;i<n;i++)
	{
		tabx[i]=tabb[i];	
	}
	
	for (int i=0;i<n;i++)
	{
		for (int j=0;j<n;j++)
		{
		 tabb[i]=tabb[i]+(tabd[i][j]*tabx[j]);
		} 
	}
  cout<<"Wektor rozwiazania to:"<<endl;
  
  for(int j=0;j<n;j++)
	{
		cout<<tabb[j]<<endl;
	}
	return 0;
}
else
{
	cout<<"Wyznacznik wiekszy od 1"<<endl;
}
}
