using DevExpress.Mvvm;
using ReaderExample.Reader;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace ReaderExample.ViewModels
{
    class StartWindowViewModel : ViewModelBase
    {
        public IAsyncCommand ReadBookCommand { get; set; }

        private Book choisedBook;
        private readonly StartWindow startWindow;
        private ObservableCollection<Book> books;
        private string image;

        private readonly string[] textOfLordOfTheRings =
        {
            @"When Mr. Bilbo Baggins of Bag End announced that he would shortly
be celebrating his eleventy-first birthday with a party of special magnificence, there was much talk and excitement in Hobbiton.
Bilbo was very rich and very peculiar, and had been the wonder
of the Shire for sixty years, ever since his remarkable disappearance
and unexpected return. The riches he had brought back from his
travels had now become a local legend, and it was popularly believed,
whatever the old folk might say, that the Hill at Bag End was full of
tunnels stuffed with treasure. And if that was not enough for fame,
there was also his prolonged vigour to marvel at. Time wore on, but it
seemed to have little effect on Mr. Baggins. At ninety he was much the
same as at fifty. At ninety-nine they began to call him well-preserved; but
unchanged would have been nearer the mark. There were some that
shook their heads and thought this was too much of a good thing; it
seemed unfair that anyone should possess (apparently) perpetual
youth as well as (reputedly) inexhaustible wealth.
‘It will have to be paid for,’ they said. ‘It isn’t natural, and trouble
will come of it!’",
            @"But so far trouble had not come; and as Mr. Baggins was generous
with his money, most people were willing to forgive him his oddities
and his good fortune. He remained on visiting terms with his relatives
(except, of course, the Sackville-Bagginses), and he had many devoted admirers among the hobbits of poor and unimportant families.
But he had no close friends, until some of his younger cousins began
to grow up.
The eldest of these, and Bilbo’s favourite, was young Frodo
Baggins. When Bilbo was ninety-nine he adopted Frodo as his heir,
and brought him to live at Bag End; and the hopes of the SackvilleBagginses were finally dashed. Bilbo and Frodo happened to have
the same birthday, September 22nd. ‘You had better come and live
here, Frodo my lad,’ said Bilbo one day; ‘and then we can celebrate
our birthday-parties comfortably together.’ At that time Frodo was
still in his tweens, as the hobbits called the irresponsible twenties
between childhood and coming of age at thirty-three",
            @"Twelve more years passed. Each year the Bagginses had given
very lively combined birthday-parties at Bag End; but now it was
understood that something quite exceptional was being planned for
that autumn. Bilbo was going to be eleventy-one, 111, a rather curious
number, and a very respectable age for a hobbit (the Old Took himself
had only reached 130); and Frodo was going to be thirty-three, 33, an
important number: the date of his ‘coming of age’.
Tongues began to wag in Hobbiton and Bywater; and rumour of
the coming event travelled all over the Shire. The history and character of Mr. Bilbo Baggins became once again the chief topic of conversation; and the older folk suddenly found their reminiscences in
welcome demand.
No one had a more attentive audience than old Ham Gamgee,
commonly known as the Gaffer. He held forth at The Ivy Bush, a
small inn on the Bywater road; and he spoke with some authority,
for he had tended the garden at Bag End for forty years, and had
helped old Holman in the same job before that. Now that he was
himself growing old and stiff in the joints, the job was mainly carried
on by his youngest son, Sam Gamgee. Both father and son were on
very friendly terms with Bilbo and Frodo. They lived on the Hill
itself, in Number 3 Bagshot Row just below Bag End."
        };

        private readonly string[] textOfHarryPoter =
        {
            @"Mr and Mrs Dursley, of number four, Privet Drive, were proud to 
say that they were perfectly normal, thank you very much. They 
were the last people you’d expect to be involved in anything 
strange or mysterious, because they just didn’t hold with such 
nonsense. 
Mr Dursley was the director of a firm called Grunnings, which 
made drills. He was a big, beefy man with hardly any neck, 
although he did have a very large moustache. Mrs Dursley was 
thin and blonde and had nearly twice the usual amount of neck, 
which came in very useful as she spent so much of her time craning 
over garden fences, spying on the neighbours. The Dursleys had a 
small son called Dudley and in their opinion there was no finer 
boy anywhere. 
The Dursleys had everything they wanted, but they also had a 
secret, and their greatest fear was that somebody would discover 
it. They didn’t think they could bear it if anyone found out about 
the Potters. Mrs Potter was Mrs Dursley’s sister, but they hadn’t 
met for several years; in fact, Mrs Dursley pretended she didn’t 
have a sister, because her sister and her good-for-nothing husband 
were as unDursleyish as it was possible to be. The Dursleys 
shuddered to think what the neighbours would say if the Potters 
arrived in the street. The Dursleys knew that the Potters had a 
small son, too, but they had never even seen him. This boy was 
another good reason for keeping the Potters away; they didn’t 
want Dudley mixing with a child like that.",
            @"When Mr and Mrs Dursley woke up on the dull, grey Tuesday 
our story starts, there was nothing about the cloudy sky outside to 
suggest that strange and mysterious things would soon be happening all over the country. Mr Dursley hummed as he picked out 
his most boring tie for work and Mrs Dursley gossiped away 
happily as she wrestled a screaming Dudley into his high chair. 
None of them noticed a large tawny owl flutter past the window. 
At half past eight, Mr Dursley picked up his briefcase, pecked 
Mrs Dursley on the cheek and tried to kiss Dudley goodbye but 
missed, because Dudley was now having a tantrum and throwing 
his cereal at the walls. ‘Little tyke,’ chortled Mr Dursley as he left 
the house. He got into his car and backed out of number four’s 
drive. 
It was on the corner of the street that he noticed the first sign 
of something peculiar – a cat reading a map. For a second, Mr 
Dursley didn’t realise what he had seen – then he jerked his head 
around to look again. There was a tabby cat standing on the corner 
of Privet Drive, but there wasn’t a map in sight. What could 
he have been thinking of? It must have been a trick of the light. 
Mr Dursley blinked and stared at the cat. It stared back. As Mr 
Dursley drove around the corner and up the road, he watched the 
cat in his mirror. It was now reading the sign that said Privet Drive
– no, looking at the sign; cats couldn’t read maps or signs. Mr 
Dursley gave himself a little shake and put the cat out of his 
mind. As he drove towards town he thought of nothing except a 
large order of drills he was hoping to get that day. 
But on the edge of town, drills were driven out of his mind by 
something else. As he sat in the usual morning traffic jam, he 
couldn’t help noticing that there seemed to be a lot of strangely 
dressed people about. People in cloaks. Mr Dursley couldn’t bear 
people who dressed in funny clothes – the get-ups you saw on 
young people! He supposed this was some stupid new fashion. He 
drummed his fingers on the steering wheel and his eyes fell on a 
huddle of these weirdos standing quite close by. They were whispering excitedly together. Mr Dursley was enraged to see that a 
couple of them weren’t young at all; why, that man had to be older 
than he was, and wearing an emerald-green cloak! The nerve of 
him! But then it struck Mr Dursley that this was probably some 
silly stunt – these people were obviously collecting for something 
... yes, that would be it. The traffic moved on, and a few minutes 
later, Mr Dursley arrived in the Grunnings car park, his mind 
back on drills. ",
            @"Mr Dursley always sat with his back to the window in his office 
on the ninth floor. If he hadn’t, he might have found it harder to 
concentrate on drills that morning. He didn’t see the owls 
swooping past in broad daylight, though people down in the 
street did; they pointed and gazed open-mouthed as owl after owl 
sped overhead. Most of them had never seen an owl even at nightime. 
Mr Dursley, however, had a perfectly normal, owl-free morning. He yelled at five different people. He made several important 
telephone calls and shouted a bit more. He was in a very good 
mood until lunch-time, when he thought he’d stretch his legs 
and walk across the road to buy himself a bun from the baker’s 
opposite. 
He’d forgotten all about the people in cloaks until he passed a 
group of them next to the baker’s. He eyed them angrily as he 
passed. He didn’t know why, but they made him uneasy. This lot 
were whispering excitedly, too, and he couldn’t see a single 
collecting tin. It was on his way back past them, clutching a large 
doughnut in a bag, that he caught a few words of what they were 
saying."
        };

        public StartWindowViewModel(StartWindow startWindow)
        {
            this.startWindow = startWindow; 
            var lordOfTheRingBook = new Book("Lord of the Rings", "J. R. R. Tolkien", 233, textOfLordOfTheRings, "71jLBXtWJWL_.jpg");
            var harryPotterBook = new Book("Harry Potter and philosopher`s stone", "J.K. Rolling", 304, textOfHarryPoter, "9780747574477-fr.jpg");

            Books = new ObservableCollection<Book>(new Book[] { lordOfTheRingBook, harryPotterBook });         
            ReadBookCommand = new AsyncCommand(ReadBookCommandExecute, CanReadBookCommandExecute);
        }              

        public ObservableCollection<Book> Books 
        { 
            get => books;
            set
            {
                books = value;
                RaisePropertyChanged(nameof(Books));
            }
        }
        public string Image 
        {
            get => image; 
            set
            {
                image = value;
                RaisePropertyChanged(nameof(Image));
            }
        }

        public Book ChoisedBook
        {
            get => choisedBook;
            set
            {
                choisedBook = value;
                Image = choisedBook.Image;

                RaisePropertyChanged(nameof(ChoisedBook));
                RaisePropertyChanged(nameof(Image));
            }
        }

        #region Commands
        private Task ReadBookCommandExecute()
        {
            var window = new MainWindow
            {
                DataContext = new MainWindowViewModel(choisedBook),
                Title = choisedBook.Title
            };

            window.Show();
            startWindow.Close();

            return Task.CompletedTask;
        }

        private bool CanReadBookCommandExecute() => choisedBook != null;
        #endregion
    }
}
