using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace car_racing_game
{
    public partial class Form1 : Form
    {
        List<PictureBox> listRoadLines = new List<PictureBox>();
        List<PictureBox> lstCars = new List<PictureBox>();

        bool isRightKeyClicked;
        bool isLeftKeyClicked;

        bool isGameFinished;

        bool isFuelDecreased;
        bool isFuelDecrementAllowed;

        bool isSpeedIncreased;

        bool isGettingFuelAllowed;
        bool isFuelCreated;

        int carSpeed = 2;
        int gamePoint = 0;

        public Random rnd;
        
        public Form1()
        {
            InitializeComponent();
            addRoadLinesToList();
            addCarsToList();
        }
        void addRoadLinesToList()
        {
            listRoadLines.Add(roadLine1);
            listRoadLines.Add(roadLine2);
            listRoadLines.Add(roadLine3);
            listRoadLines.Add(roadLine4);
            listRoadLines.Add(roadLine5);
            listRoadLines.Add(roadLine6);
            listRoadLines.Add(roadLine7);
            listRoadLines.Add(roadLine8);
        }
        void addCarsToList()
        {
            lstCars.Add(PBoxCar1);
            lstCars.Add(PBoxCar2);
            lstCars.Add(PBoxCar3);
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                isRightKeyClicked = true;
            }

            else if (e.KeyCode == Keys.Left)
            {
                isLeftKeyClicked = true;
            }
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            isRightKeyClicked = false;
            isLeftKeyClicked = false;
        }
        public void gameMover_Tick(object sender, EventArgs e)
        {
            gamePlay();
        }
        void gamePlay()
        {
            operateCarMove();

            allowFuelCreation();
            operateFuelCreation();
            moveFuelOil();
            isFuelWasted();
            allowCarFuelDecrement();
            decreaseFuel();

            operateFuelGetting();

            moveRoadLines();

            for (int i = 0; i < lstCars.Count; i++)
            {
                moveOpCar(lstCars[i]);
            }

            lblScore.Text = "Score " + gamePoint;

            increaseCarSpeed();
            lblCarSpeed.Text = "Speed " + carSpeed * 10;

            checkForWinner();

            checkIsFuelOver();

            detectCarCrush();
        }
        void operateCarMove()
        {
            if (!isGameFinished)//to stop right/left move of the car when the game is over
            {
                if (isCarBetweenBorders())
                {
                    moveCar();
                }
                correctCarLocation();
            }
        }
        private bool isCarBetweenBorders()
        {
            bool status = false;
            if (car.Location.X >= 0 && car.Location.X <= 205)
            {
                status = true;
            }
            return status;
        }
        void moveCar()
        {
            if (isRightKeyClicked)
            {
                car.Left += 5;
            }
            else if (isLeftKeyClicked)
            {
                car.Left -= 5;
            }
        }
        void correctCarLocation()
        {
            int carLocX = car.Location.X;

            if (carLocX > 205)
            {
                carLocX = 205;
            }
            else if (carLocX < 0)
            {
                carLocX = 0;
            }
            car.Location = new Point(carLocX, car.Location.Y);
        }
        void allowFuelCreation()
        {
            if (gamePoint % 10 >= 0 && gamePoint % 10 <= 2)
            {
                isGettingFuelAllowed = true;
            }
            else
            {
                isGettingFuelAllowed = false;
                isFuelCreated = false;
            }
        }
        void operateFuelCreation()
        {
            if (!fuelOil.Visible && !isFuelCreated && isGettingFuelAllowed && gamePoint > 9)
            {
                isFuelCreated = true;
                createFuelOil();//fuel is created when 10 cars passed

                isSpeedIncreased = true;//car speed must be increased every 10 cars too
            }
        }
       
        void createFuelOil()
        {
            fuelOil.Visible = true;
            detectFuelLocation();
        }
        void detectFuelLocation()
        {
            rnd = new Random();
            int fuelOilLocX = rnd.Next(0, 200);
            fuelOil.Location = new Point(fuelOilLocX, 0);
            checkFuelOpCarCollision();
        }
        void checkFuelOpCarCollision()
        {
            for (int i = 0; i < lstCars.Count; i++)
            {
                if (fuelOil.Bounds.IntersectsWith(lstCars[i].Bounds))
                {
                    fuelOil.Location = new Point(fuelOil.Location.X, -50);
                }
            }
        }
        void moveFuelOil()
        {
            if (fuelOil.Visible)
            {
                fuelOil.Top += carSpeed;
            }
        }
        void isFuelWasted()
        {
            if (fuelOil.Top >= panel1.Height)
            {
                fuelOil.Visible = false;
            }
        }
        
        /// <summary>
        /// decrease car fuel every 5 cars passed
        /// % 5 == 0 can't be caught, so i put a car border
        /// </summary>
        void allowCarFuelDecrement()
        {
            if (gamePoint % 5 >= 0 && gamePoint % 5 <= 2)
            {
                isFuelDecrementAllowed = true;
            }
            else
            {
                isFuelDecrementAllowed = false;
                isFuelDecreased = false;
            }
        }
        void decreaseFuel()
        {
            if (gamePoint > 12 && isFuelDecrementAllowed && !isFuelDecreased)
            {
                carFuelGauge.Value--;
                isFuelDecreased = true;
            }
        }
        void operateFuelGetting()
        {
            if (fuelOil.Bounds.IntersectsWith(car.Bounds) && fuelOil.Visible)
            {
                getFuel();
            }
        }
       
        void getFuel()
        {
            if (carFuelGauge.Value < 10)
            {
                fuelOil.Visible = false;
                isGettingFuelAllowed = true;
                carFuelGauge.Value++;
            }
        }
        
        void moveRoadLines()
        {
            for (int i = 0; i < listRoadLines.Count; i++)
            {
                listRoadLines[i].Top += carSpeed;
                if (listRoadLines[i].Top >= 400)
                {
                    listRoadLines[i].Top = -100;
                }
            }
        }
        void moveOpCar(PictureBox opCar)
        {
            opCar.Top += carSpeed;
            if (opCar.Top > panel1.Height)
            {
                gamePoint++;
                detectOppositeCarLoc(opCar);
            }
        }
        void detectOppositeCarLoc(PictureBox opCar)
        {
            rnd = new Random();
            Point opCarLoc;

            if (opCar == PBoxCar1)
            {
                opCarLoc = calculateOpCar1Loc();
            }

            else if (opCar == PBoxCar2)
            {
                opCarLoc = calculateOpCar2Loc();
            }

            else
            {
                opCarLoc = calculateOpCar3Loc();
            }
            opCar.Location = opCarLoc;
        }
        private Point calculateOpCar1Loc()
        {
            Point p = new Point();
            p.X = rnd.Next(0, 48);
            p.Y = (p.X - 25);

            if (p.X >= 25)
            {
                p.Y = -(p.X - 25);
            }
            return p;
        }
        private Point calculateOpCar2Loc()
        {
            Point p = new Point();
            p.X = rnd.Next(76, 133);
            p.Y = (p.X - 133);
            if (p.X >= 104)
            {
                p.Y = -(p.X - 104);
            }
            return p;
        }
        private Point calculateOpCar3Loc()
        {
            Point p = new Point();
            p.X = rnd.Next(160, 209);
            p.Y = (p.X - 184);
            if (p.X >= 184)
            {
                p.Y = -(p.X - 184);
            }
            return p;
        }
        void increaseCarSpeed()
        {
            if (gamePoint <= 50 && isSpeedIncreased)
            {
                isSpeedIncreased = false;
                carSpeed++;
            }
        }
        void checkForWinner()
        {
            if (carFuelGauge.Value > 0 && gamePoint >= 100)
            {
                lblGameOver.Text = "YOU WON!";
                cup.Visible = true;
                gameover();
            }
        }
        void checkIsFuelOver()
        {
            if (carFuelGauge.Value == 0)
            {
                gameover();
                lblFuelOver.Visible = true;
            }
        }
        void detectCarCrush()
        {
            for (int i = 0; i < lstCars.Count; i++)
            {
                if (car.Bounds.IntersectsWith(lstCars[i].Bounds))
                {
                    gameover();
                }
            }
        }
        public void gameover()
        {
            lblGameOver.Visible = true;
            isGameFinished = true;
            gameMover.Stop();
            btnReStart.Visible = true;
        }
        private void btnReStart_Click(object sender, EventArgs e)
        {
            gamePoint = 0;
            carFuelGauge.Value = 10;
            InitializeComponent();
            Form1 NewForm = new Form1();
            NewForm.Show();
            this.Dispose(false);
        }
    }
}
