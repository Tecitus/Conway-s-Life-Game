using System;

namespace Conway
{
    class Grid<T>{
		public T[,] grid;
		int X,Y;
		public Grid(int x, int y){
			grid = new T[x,y];
			X = x;
			Y = y;
		}

		public int GetX(){
			return X;
		}
		public int GetY(){
			return Y;
		}

		public T this[int a,int b]{get{return grid [a, b];}
			}

/*		public void setgrid(T[,] rgrid){
			grid = rgrid;
		}*/
	}

	class Game{
		public Grid<bool> grid;
		float tick;
		public void NewGrid(int x,int y){
			grid = new Grid<bool> (x, y);
		}

		public void Draw(Grid<bool> grid){
			for (int i = 0; i < grid.GetX (); i++) {
				for (int k = 0; k < grid.GetY (); k++) {
					if (grid [k, i] == true)
						Console.Write ('■');
					else
						Console.Write ('□');
				}
				Console.Write ('\n');
			}
		}






		public void Regen (){
			Grid<bool> rgrid = new Grid<bool>(grid.GetX(), grid.GetY());
			short counter = 0;
			for(int x = 0;x<rgrid.GetX();x++){
				for(int y = 0;y<rgrid.GetY();y++){
					counter = 0;
					for (int i = -1; i <2; i++) {
						for (int k = -1; k < 2; k++) {
							if (i == 0 && k == 0)
								continue;
							if (x + k< 0 || x + k > grid.GetX()-1 || y + i < 0 || y + i > grid.GetY()-1)
								continue;
							if (grid.grid [x+k, y+i] == true)
									counter+=1;
							
					
						}
					}
					if (counter == 3)
						rgrid.grid[x, y] = true;
					else if (counter == 2)
						rgrid.grid[x, y] = grid.grid[x, y];
					else
						rgrid.grid [x, y] = false;
						
				}
			}
			grid = rgrid;
		}
	}
}
