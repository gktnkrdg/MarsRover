using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Core
{
    public class Rover
    {
		public Plateau Plateau { get; private set; }
        public Position Position { get; private set; }	
        public Rover(Plateau Plateau ,Position position)
        {
			this.Plateau = Plateau;
            this.Position = position;
        }

	    public void Move()
        {
			switch (Position.Direction)
			{
				case Direction.N:
					SetCoordinate(new Coordinate(Position.Coordinate.X, (++Position.Coordinate.Y)));
					break;
				case Direction.W:
					SetCoordinate(new Coordinate((--Position.Coordinate.X), Position.Coordinate.Y));
					break;
				case Direction.S:
					SetCoordinate(new Coordinate(Position.Coordinate.X, (--Position.Coordinate.Y)));
					break;
				case Direction.E:
					SetCoordinate(new Coordinate(++Position.Coordinate.X, Position.Coordinate.Y));
					break;
				default:
					break;
			}
		}

        

        public void TurnLeft()
		{
			switch (Position.Direction)
			{
				case Direction.N:
					SetDirection(Direction.W);
					break;
				case Direction.W:
					SetDirection(Direction.S);
					break;
				case Direction.S:
					SetDirection(Direction.E);
					break;
				case Direction.E:
					SetDirection(Direction.N);
					break;
				default:
					break;
			}
		}

		public void TurnRight()
		{
			switch (Position.Direction)
			{
				case Direction.N:
					SetDirection(Direction.E);
					break;
				case Direction.W:
					SetDirection(Direction.N);
					break;
				case Direction.S:
					SetDirection(Direction.W);
					break;
				case Direction.E:
					SetDirection(Direction.S);
					break;
				default:
					break;
			}
		}
		public void ExecuteCommands(string commands)
		{
			foreach (var command in commands)
            {
                ExecuteCommand(command);
            }
        }

        private void ExecuteCommand(char command)
        {
            switch (command)
            {
                case ('L'):
                    TurnLeft();
                    break;
                case ('R'):
                    TurnRight();
                    break;
                case ('M'):
                    Move();
                    break;
                default:
                    throw new InvalidOperationException($" {command} command is not validd");
            }
        }

        private void SetDirection(Direction direction)
        {
			this.Position.Direction = direction;
        }
		private void SetCoordinate(Coordinate coordinate)
		{
			if (!IsValidCoordinate(coordinate))
				throw new InvalidOperationException($"Coorddinate { coordinate }  is not valid");
			this.Position.Coordinate = coordinate;
		}

        private bool IsValidCoordinate(Coordinate coordinate)
        {
			if (coordinate.X > Plateau.Width || coordinate.Y > Plateau.Height)
				return false;
			if (coordinate.X < 0 || coordinate.Y < 0)
				return false;
			return true;
        }

		public string GetRoverPositionDetailedString()
        {
			return Position.Coordinate.X + " " + Position.Coordinate.Y + " " + Position.Direction.ToString();
        }
	
	}
}
