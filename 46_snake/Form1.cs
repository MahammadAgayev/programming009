using System.Net.Http.Json;

namespace _46_snake
{
    public partial class Form1 : Form
    {
        private readonly GameOptions _gameOptions;
        private readonly System.Timers.Timer _timer;

        private readonly List<Circle> _snake = new List<Circle>();
        private Circle _food;

        private int _currentDirection = Direction.Right;

        private bool _isGameOver = false;

        public Form1()
        {
            InitializeComponent();

            _gameOptions = new GameOptions
            {
                Width = 30,
                Height = 30
            };

            _timer = new System.Timers.Timer();
            _timer.Elapsed += timeElapsed;
            _timer.Interval = 500;

            NewGame();
        }

        private void timeElapsed(object? sender, System.Timers.ElapsedEventArgs e)
        {
            Circle head = _snake[0];

            if(head.X == _food.X && head.Y == _food.Y)
            {
                EatFood();
            }

            if(head.X > pnlGame.Width / _gameOptions.Width 
                || head.Y > pnlGame.Height / _gameOptions.Height
                || head.X < 0 
                || head.Y < 0)
            {
                GameOver();
            }

            for (int i = _snake.Count - 1; i > 0; i--)
            {
                _snake[i].X = _snake[i - 1].X;
                _snake[i].Y = _snake[i - 1].Y;
            }

            switch (_currentDirection)
            {
                case Direction.Left:
                    head.X--;
                    break;
                case Direction.Right:
                    head.X++;
                    break;
                case Direction.Up:
                    head.Y--;
                    break;
                case Direction.Down:
                    head.Y++;
                    break;
            }

            for (int i = 1; i < _snake.Count; i++)
            {
                if (_snake[i].X == head.X &&
                    _snake[i].Y == head.Y)
                {
                    GameOver();
                }
            }

            pnlGame.Invalidate();
        }

        private void GameOver()
        {
            _isGameOver = true;
        }

        private void EatFood()
        {
            Circle head = _snake[0];
            _snake.Add(new Circle
            {
                X = head.X,
                Y = head.Y,
            });

            NewFood();
        }

        private void NewGame()
        {
            _isGameOver = false;
            Circle head = new Circle
            {
                X = 0,
                Y = 0
            };

            _snake.Clear();
            _snake.Add(head);
            _currentDirection = Direction.Right;
            NewFood();

            _timer.Start();
        }

        private void NewFood()
        {
            Random random = new Random();
            _food = new Circle
            {
                X = random.Next(0, pnlGame.Width / _gameOptions.Width),
                Y = random.Next(0, pnlGame.Height / _gameOptions.Height)
            };
        }

        private void pnlGame_Paint(object sender, PaintEventArgs e)
        {
            if(_isGameOver)
            {
                lblGameOver.Visible = true;
                return;
            }
            else
            {
                lblGameOver.Visible = false;
            }

            Graphics g = e.Graphics;

            foreach (var item in _snake)
            {
                g.FillEllipse(Brushes.Red, new Rectangle(item.X * _gameOptions.Width, item.Y * _gameOptions.Height, _gameOptions.Width, _gameOptions.Height));
            }

            g.FillEllipse(Brushes.Yellow, new Rectangle(_food.X * _gameOptions.Width, _food.Y * _gameOptions.Height, _gameOptions.Width, _gameOptions.Height));
        }

        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up when _currentDirection != Direction.Down:
                    _currentDirection = Direction.Up;
                    break;
                case Keys.Down when _currentDirection != Direction.Up:
                    _currentDirection = Direction.Down;
                    break;
                case Keys.Left when _currentDirection != Direction.Right:
                    _currentDirection = Direction.Left;
                    break;
                case Keys.Right when _currentDirection != Direction.Left:
                    _currentDirection = Direction.Right;
                    break;
                case Keys.Enter:
                    NewGame();
                    break;

            }
        }
    }
}