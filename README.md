# TrickOrTreat
## Windows forms .NET/C# проект развиен од Лабина Стаменкова 193033

### Опис на апликацијата
-	Trick or Treat е едноставна игра развиена во C#, со помош на Windows Forms интерфејсот, кој е дел од Microsoft .NET framework. 
Идејата за оваа игра не е нова, но верувам дека би била доволно интересна за секој корисник поради разиграниот дизајн. 
Главната цел на оваа игра е да му помогнете на карактерот (маченцето) да собере што е можно подобри и повкусни закуски и успешно да го избегнете непријателот. 
Едноставно кажано, целта е играчот да собере што е можно повеќе поени за да го сруши рекордот (high score).

### Како се игра
-	Карактерот, кој е лоциран на долниот дел од формата, се движи или налево или надесно, со стискање на левата или десната стрелка, 
или пак со стискање на А копчето за лево и D копчето за десно. Маченцето се движи со постојана брзина, 
за разлика од објектите и непријателот чии што брзини се зголемуваат како што се зголемува бројот на поени. 
Постојат 6 различни објекти, односно закуски кои што паѓаат од горниот дел на формата, надоле. Три од нив даваат различен број на позитивни поени, 
а другите три даваат различен број на негативни поени, од кои една од тие негативни закуски одзема и по еден од животите на маченцето. 
Крајот на играта е кога маченцето ќе ги изгуби сите свои животи или пак кога ќе биде фатено од страна на непријателот (лилјакот) 
кој што постојано се појавува и исто така се движи налево и надесно.

### Класи, контроли и податочни структури
-	За имплементација на апликацијата искористив 4 форми – StartScreen (форма во која се имплементира почетната страна на апликацијата), 
HelpScreen (форма во која што се имплементира објаснување за тоа како се игра играта), Form1 (форма во која што се имплементира играта) и 
GameOver (форма во која се имплементира приказот на тековниот број на поени и бројот на рекорди поени (high score)). 
Употребив и контроли како timer (за движење на објектите и за одредување на интервал во кој тие ќе се појавуваат), 
picture box (за некои визуелни детали како икони или натписи), label и buttons. Покрај класите за формите, 
креирав класа GameObject (во која се чуваат главните променливи и методи за функционалност на објектите како move() и draw()), 
од која наследуваат класите Avatar (класа за карактерот), Enemy (класа за непријателот) и FallingObject (класа за секој објект кој паѓа надоле). 
Потоа имаме и класи како HighScore (класа која е серијализирана со цел да се овозможи чување на рекордот и по затворањето на формата, како и негово ресетирање)
и Sound, кои што се мали класи и едната го чува само рекордот во една int променлива, a другата
преку инстанца на SoundPlayer пушта соодветни звуци по случувањето на одредени насани во кодот како крајот на играта или колизија меѓу објекти, односно
ако карактерот собере некоја закуска.
Според мене најважните класи се класата Game и класата ObjectFactory која го имплементира интерфејсот Factory. 
Класата Game чува по една инстанца од карактерот, непријателот, листа од паѓачки објекти, неколку EventHandler-и на кои што се претплатени другите класи
и дополнителни променливи и објекти кои што се многу важни за целокупната функционалност
на играта. Само методите од оваа класа директно се повикуваат од главната форма, односно Form1, така што само преку оваа класа може да се работи со сите останати класи.
Класата ObjectFactory е креирана според Factory и Singleton шаблонот и покрај инстанцата од сама себе, содржи и објект од класата Random, 
кој помага во задавање на различни позиции кога се креира нов GameObject. 
```
public interface Factory
    {
        GameObject createObject(int type, int formWidth, int formHeight); //за креирање на секој вид на GameObject
        FallingObject createExtraLife(int formWidth, int formHeight); //За креирање на дополнителен живот
        Avatar createAvatar(int formWidth, int formHeight); //За креирањето на инстанцата на карактерот
        Enemy createEnemy(int formWidth, int formHeight); //За креирањето на инстанцата на непријателот

    }
```
```
public class ObjectFactory : Factory
    {
        enum TYPE { MILK, BOWL, SALMON, RAT, CHOCOLATE, SKELETON, LIFE, KITTY, BAT }; //енумерација на сите видови на објекти кои што е возможно да се креираат

        private static ObjectFactory instance = null;
        private static Random random;

        private ObjectFactory()
        {
            random = new Random();
        }

        public static ObjectFactory getInstance()
        {
            if (instance == null)
                instance = new ObjectFactory();

            return instance;
        }

        public GameObject createObject(int type, int formWidth, int formHeight) //во оваа функција се креира секој вид на GameObject
        {
            TYPE fallingObject = (TYPE)type; 

            switch (fallingObject) //вредностите за креирање на секој објект освен позицијата на објектот се предходно осмислени и се исти за секој нов објект од истиот вид
            { 
                case TYPE.MILK:
                    return new FallingObject(Properties.Resources.milk_bottle,
                        new Rectangle(random.Next(1, formWidth-20), random.Next(-250,-10), 20, 45), 1, 0); //конструкторот за GameObject прифаќа објекти и променливи од тип
                case TYPE.BOWL:                                                                            //Image, Rectangle, int, int за изгледот на објектот, неговите димензии
                    return new FallingObject(Properties.Resources.cat_bowl,                                //бројот на бодови кој го носи и бројот на животи кои ги додава
                        new Rectangle(random.Next(1, formWidth-45), random.Next(-250, -10), 45, 35), 2, 0);
                case TYPE.SALMON:
                    return new FallingObject(Properties.Resources.cute_salmon,
                        new Rectangle(random.Next(1, formWidth-40), random.Next(-250, -10), 40, 30), 3, 0);
                case TYPE.RAT:
                    return new FallingObject(Properties.Resources.rat,
                        new Rectangle(random.Next(1, formWidth-40), random.Next(-250, -10), 40, 30), -1, 0);
                case TYPE.CHOCOLATE:
                    return new FallingObject(Properties.Resources.angry_chocolate,
                        new Rectangle(random.Next(1, formWidth-30), random.Next(-250, -10), 30, 45), -3, 0);
                case TYPE.SKELETON:
                    return new FallingObject(Properties.Resources.fish_skeleton,
                        new Rectangle(random.Next(1, formWidth-50), random.Next(-250, -10), 50, 25), -5, -1);
                case TYPE.LIFE:
                    return new FallingObject(Properties.Resources.life,
                        new Rectangle(random.Next(1, formWidth), -30, 30, 30), 0, 1);
                case TYPE.KITTY:
                    return Avatar.getInstance(Properties.Resources.Left,
                        new Rectangle(formWidth / 2 - 85 / 2, formHeight - 85, 85, 85));
                case TYPE.BAT:
                    return Enemy.getInstance(Properties.Resources.bat_enemy,
                        new Rectangle(random.Next(1, formWidth - 80), -30, 80, 50));

                default: return null;
            }

        }

        public FallingObject createExtraLife(int formWidth, int formHeight)
        {
            return (FallingObject) createObject(6, formWidth, formHeight);
        }

        public Avatar createAvatar(int formWidth, int formHeight)
        {
            return (Avatar) createObject(7, formWidth, formHeight);
        }

        public Enemy createEnemy(int formWidth, int formHeight)
        {
            return (Enemy) createObject(8, formWidth, formHeight);
        }
    }
```

### Алгоритми
- Поради едноставноста на оваа игра, се користат само кратки алгоритми за промена на положбата на објектот и за проверка дали објектите се во колизија. Методот со кој се
започнува играта се наоѓа во класата на формата Form1:
```
private void startGame()
        {
            game = Game.getInstance(this.ClientSize.Width, this.ClientSize.Height); //се креира главниот game објект преку кој ќе се повикуваат методите за имплементација на нејзината функционалност
            game.EndEvent += Game_EndEvent; //се претплатува на настанот кој означува крај на играта

            //и поради едноставноста на играта, за нејзино стартирање потребно е само да ги стартираме сите тајмери
            generatorTimer.Interval = random.Next(500, 4000); 
            batTimer.Interval = random.Next(5000, 25000); 
            lifeTimer.Interval = random.Next(10000, 50000);
            totalScore.Text = game.totalScore.ToString();
            remainingLives.Text = game.totalLives.ToString();       

            moveTimer.Start(); //тајмер кој овозможува движење на сите објекти на формата
            generatorTimer.Start(); //тајмер кој повикува генерирање на нов паѓачки објект
            batTimer.Start(); //тајмер кој му овозможува на непријателот да се појави на формата
            batDirection.Start(); //тајмер кој во секој интервал му го менува правецот на движење на непријателот
            lifeTimer.Start(); //тајмер кој повикува генерирање на нов дополнителен објект за живот
        }
```
Движењето на сите објекти го контролира методот move() во класата Game:
```
public void move()
        {        //овој метод само ги повикува соодветните move методи за секој GameObject
            avatar.move(formWidth, formHeight, speed);     
            enemy.move(formWidth, formHeight, speed);

            foreach(FallingObject obj in fallingObjects)
            {
                obj.move(formWidth, formHeight, speed);
            }

            update(); //овој метод е еден од поважните бидејќи после секое придвижување со овој метод се проверува кои објекти се надвор од формата, дали имало колизија и повикува настани
        }
```
```
private void update()
        {
            adjustSpeed(); //промена на брзина на сите објекти освен карактерот

            if (enemy.checkIfCaught(avatar) || totalLives == 0) //ако карактерот е фатен од страна на непријателот или ги изгуби сите животи, повикај настани за крај на играта
            {
                if (GameOverEvent != null) //настан на кој е претплатена Sound класата
                   GameOverEvent.Invoke(this, EventArgs.Empty);
                if (EndEvent != null) //настан на кој е претплатена Form1
                    EndEvent.Invoke(this, EventArgs.Empty);               
            }

            else
            {
                for(int i = fallingObjects.Count -1; i >= 0; i--) //циклус кој ги изминува сите паѓачки објекти
                {
                    if (avatar.checkIntersection(fallingObjects[i])) //ако некој од објектите е во колизија со карактерот
                    {
                        if (CollectedObjectEvent != null) //разбуди го настанот за собирање на објект
                            CollectedObjectEvent.Invoke(this, EventArgs.Empty);

                        totalScore += fallingObjects[i].points; //се додаваат поените кои ги носат објектите на вкупните поени
                        totalLives += fallingObjects[i].lives; //се додаваат животите кои ги носат објектите на вкупните животи
                        fallingObjects.RemoveAt(i); //отстрани го објектот, бидејќи е фатен
                    }

                    else if (fallingObjects[i].outOfBounds) //ако објектот е надвор од видикот во формата отстрани го
                        fallingObjects.RemoveAt(i);
                }
            }
        }
```
Алгоритмот со кој се проверува дали објектите се во колизија:
```
public bool checkIntersection(FallingObject obj)
        {
            return 45 * 45 > Math.Pow(X - obj.X, 2) + Math.Pow(Y - obj.Y, 2); //ако центрите на објектите им се оддалечени помалку од 45 единици, објектите се во колизија
        }
```
По будење на настаните за крај на играта, се повикува и функцијата за крај на игра во Form1:
```
private void Game_EndEvent(object sender, EventArgs e)
        {
            endGame();
        }
        
private void endGame()
        { //се прекинуваат сите тајмери и се креира објект за новата форма која што треба да се прикаже
        
            GameOver gameOverScreen = new GameOver(game.totalScore); //серијализацијата на рекордот е имплементирана во класата на оваа форма
            moveTimer.Stop();
            generatorTimer.Stop();
            batTimer.Stop();
            batDirection.Stop();
            lifeTimer.Stop();
            game.resetGame(); //метод кој што ги сетира сите инстанци на singleton класите на null

            gameOverScreen.Width = this.Width; //новата форма ја зема ширината на моменталната форма
            gameOverScreen.Height = this.Height; //новата форма ја зема висината на моменталната форма
            gameOverScreen.StartPosition = FormStartPosition.Manual; //новата форма ја зема стартната позиција на моменталната форма
            gameOverScreen.Location = new Point(this.Location.X, this.Location.Y); //ја зема локацијата
            this.Visible = false; //моменталната форма ја правиме да не биде повеќе прикажана
            gameOverScreen.ShowDialog(); //отвори ја новата форма
            //this.Visible = true;

        }
```

Серијализација на рекордот и негово ресетирање:
```
private void saveHighScore()
        {
            if(totalScore > highScore.highScore)
            {
                highScore.highScore = totalScore;
            }

            var serializer = new XmlSerializer(highScore.GetType());
            using (var writer = new StreamWriter("highscores.xml", false))
            {
                serializer.Serialize(writer.BaseStream, highScore);
            }

        }

        private void loadHighScore()
        {
            var serializer = new XmlSerializer(highScore.GetType());
            object obj;
            try
            {
                using (var reader = new StreamReader("highscores.xml"))
                {
                    obj = serializer.Deserialize(reader.BaseStream);
                }
                highScore = (HighScore)obj;
            }
            catch(Exception ex)
            {
                highScore = new HighScore();
                return;
            }
            
        }
        private void clearHighScore(object sender, EventArgs e)
        {
            highScore = new HighScore();
            var serializer = new XmlSerializer(highScore.GetType());
            using (var writer = new StreamWriter("highscores.xml", false))
            {
                serializer.Serialize(writer.BaseStream, highScore);
            }
            highScoreText.Text = highScore.highScore.ToString();
        }
```
### Изгледот на играта
