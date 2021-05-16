namespace UnitTests.FakeRepositories
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Threading.Tasks;
    using DoctorsApplicationMicroservice.Web.Application.Dtos;

    public class TestDoctorRepository
    {
        private List<DoctorDto> _doctorsList { get; set; }

        public TestDoctorRepository()
        {
            _doctorsList = new List<DoctorDto>();
            init();
        }
        
        public Task<IEnumerable<DoctorDto>> GetDoctorsAsync()
        {
            return Task.FromResult(_doctorsList as IEnumerable<DoctorDto>);
        }

        private void init()
        {
            _doctorsList = new List<DoctorDto>();
            _doctorsList.Add(new DoctorDto(0, "Buckminster", "Chapman", "018375964441"));
            _doctorsList.Add(new DoctorDto(1, "Demetrius", "Evans", "650929229020"));
            _doctorsList.Add(new DoctorDto(2, "Guy", "Johnston", "319584660440"));
            _doctorsList.Add(new DoctorDto(3, "Keaton", "Berg", "877594816155"));
            _doctorsList.Add(new DoctorDto(4, "Robert", "Benjamin", "295777249377"));
            _doctorsList.Add(new DoctorDto(5, "Thaddeus", "Blackwell", "299799036398"));
            _doctorsList.Add(new DoctorDto(6, "Graiden", "Cote", "157674526902"));
            _doctorsList.Add(new DoctorDto(7, "Troy", "Drake", "255874503350"));
            _doctorsList.Add(new DoctorDto(8, "Herrod", "Chaney", "046078285093"));
            _doctorsList.Add(new DoctorDto(9, "Zachary", "Mcknight", "524614949260"));
            _doctorsList.Add(new DoctorDto(10, "Tyrone", "Casey", "697724657043"));
            _doctorsList.Add(new DoctorDto(11, "Hall", "Sparks", "238229331361"));
            _doctorsList.Add(new DoctorDto(12, "Hakeem", "Perez", "384790956445"));
            _doctorsList.Add(new DoctorDto(13, "Flynn", "Odonnell", "233326004917"));
            _doctorsList.Add(new DoctorDto(14, "Stephen", "Vaughan", "180633002200"));
            _doctorsList.Add(new DoctorDto(15, "Yoshio", "Daugherty", "952713104749"));
            _doctorsList.Add(new DoctorDto(16, "Xavier", "Moreno", "275238227553"));
            _doctorsList.Add(new DoctorDto(17, "Ulric", "Hood", "303509830671"));
            _doctorsList.Add(new DoctorDto(18, "Alexander", "Hansen", "621728984003"));
            _doctorsList.Add(new DoctorDto(19, "Stone", "Suarez", "514660123817"));
            _doctorsList.Add(new DoctorDto(20, "Emery", "Baldwin", "771545165840"));
            _doctorsList.Add(new DoctorDto(21, "Owen", "Francis", "625208926412"));
            _doctorsList.Add(new DoctorDto(22, "Andrew", "Lester", "778972476850"));
            _doctorsList.Add(new DoctorDto(23, "Amery", "House", "814540950604"));
            _doctorsList.Add(new DoctorDto(24, "Drake", "Hutchinson", "851857963635"));
            _doctorsList.Add(new DoctorDto(25, "Gary", "Suarez", "981148788942"));
            _doctorsList.Add(new DoctorDto(26, "John", "Orr", "058249791505"));
            _doctorsList.Add(new DoctorDto(27, "Barrett", "Russo", "865743473205"));
            _doctorsList.Add(new DoctorDto(28, "Curran", "Carrillo", "786816261155"));
            _doctorsList.Add(new DoctorDto(29, "Honorato", "Trujillo", "253160111709"));
            _doctorsList.Add(new DoctorDto(30, "Beau", "Griffin", "283504986463"));
            _doctorsList.Add(new DoctorDto(31, "Deacon", "Boyd", "888802112392"));
            _doctorsList.Add(new DoctorDto(32, "Russell", "Mayo", "017616829378"));
            _doctorsList.Add(new DoctorDto(33, "Christian", "Hudson", "351162915090"));
            _doctorsList.Add(new DoctorDto(34, "Blaze", "Solis", "179549752187"));
            _doctorsList.Add(new DoctorDto(35, "Cullen", "Roberts", "307842218725"));
            _doctorsList.Add(new DoctorDto(36, "Drew", "Barker", "529132782651"));
            _doctorsList.Add(new DoctorDto(37, "Macaulay", "Valdez", "042371902330"));
            _doctorsList.Add(new DoctorDto(38, "Quinlan", "Mckay", "072482157388"));
            _doctorsList.Add(new DoctorDto(39, "Brent", "Holloway", "427037998806"));
            _doctorsList.Add(new DoctorDto(40, "Finn", "Robles", "924905942590"));
            _doctorsList.Add(new DoctorDto(41, "Michael", "West", "915773872573"));
            _doctorsList.Add(new DoctorDto(42, "Lucian", "Dennis", "426332484402"));
            _doctorsList.Add(new DoctorDto(43, "Demetrius", "Foster", "945730248640"));
            _doctorsList.Add(new DoctorDto(44, "Jonah", "Graves", "610224548235"));
            _doctorsList.Add(new DoctorDto(45, "Guy", "Duffy", "812600398795"));
            _doctorsList.Add(new DoctorDto(46, "Vladimir", "Vaughan", "606496769569"));
            _doctorsList.Add(new DoctorDto(47, "Steel", "Fitzgerald", "859864916334"));
            _doctorsList.Add(new DoctorDto(48, "Oscar", "Sellers", "891223595610"));
            _doctorsList.Add(new DoctorDto(49, "Ryder", "Estes", "932351060991"));
            _doctorsList.Add(new DoctorDto(50, "Howard", "Lloyd", "333652966774"));
            _doctorsList.Add(new DoctorDto(51, "Keane", "Randall", "874154438592"));
            _doctorsList.Add(new DoctorDto(52, "Kamal", "Battle", "162277740669"));
            _doctorsList.Add(new DoctorDto(53, "Rogan", "Chase", "406573149679"));
            _doctorsList.Add(new DoctorDto(54, "Uriel", "Sharp", "822357210472"));
            _doctorsList.Add(new DoctorDto(55, "Victor", "Franco", "681947317324"));
            _doctorsList.Add(new DoctorDto(56, "Edan", "Alford", "390687078593"));
            _doctorsList.Add(new DoctorDto(57, "Noble", "Malone", "713082775938"));
            _doctorsList.Add(new DoctorDto(58, "Chase", "Garza", "346978019469"));
            _doctorsList.Add(new DoctorDto(59, "Bevis", "Mckay", "296811752320"));
            _doctorsList.Add(new DoctorDto(60, "Tanek", "Barton", "917433211938"));
            _doctorsList.Add(new DoctorDto(61, "Fulton", "Bailey", "089507783971"));
            _doctorsList.Add(new DoctorDto(62, "Travis", "Boyle", "502250245112"));
            _doctorsList.Add(new DoctorDto(63, "Basil", "Lawrence", "807809806364"));
            _doctorsList.Add(new DoctorDto(64, "Nasim", "Foster", "915249972446"));
            _doctorsList.Add(new DoctorDto(65, "Dorian", "Bowers", "555233803963"));
            _doctorsList.Add(new DoctorDto(66, "Cole", "Lang", "997802285569"));
            _doctorsList.Add(new DoctorDto(67, "Troy", "Webb", "732979574599"));
            _doctorsList.Add(new DoctorDto(68, "Clark", "Rodriquez", "269636657449"));
            _doctorsList.Add(new DoctorDto(69, "Kibo", "Hill", "704494050765"));
            _doctorsList.Add(new DoctorDto(70, "Edan", "Lyons", "832728563302"));
            _doctorsList.Add(new DoctorDto(71, "Wesley", "Morgan", "192507200175"));
            _doctorsList.Add(new DoctorDto(72, "Laith", "Head", "922300891711"));
            _doctorsList.Add(new DoctorDto(73, "Palmer", "Kirkland", "249106030974"));
            _doctorsList.Add(new DoctorDto(74, "Brendan", "Mayer", "339384909820"));
            _doctorsList.Add(new DoctorDto(75, "Forrest", "Wallace", "857993067530"));
            _doctorsList.Add(new DoctorDto(76, "Henry", "Pearson", "933213088935"));
            _doctorsList.Add(new DoctorDto(77, "Lyle", "Lamb", "885786548426"));
            _doctorsList.Add(new DoctorDto(78, "Chancellor", "Mueller", "904960272861"));
            _doctorsList.Add(new DoctorDto(79, "Brendan", "Stephenson", "591410417676"));
            _doctorsList.Add(new DoctorDto(80, "Tiger", "Rojas", "729902776586"));
            _doctorsList.Add(new DoctorDto(81, "Finn", "Smith", "135433425292"));
            _doctorsList.Add(new DoctorDto(82, "Kane", "Peters", "412853873429"));
            _doctorsList.Add(new DoctorDto(83, "Hammett", "Thompson", "095427339531"));
            _doctorsList.Add(new DoctorDto(84, "Jelani", "Greer", "603428999077"));
            _doctorsList.Add(new DoctorDto(85, "Cole", "Hopkins", "165184123937"));
            _doctorsList.Add(new DoctorDto(86, "Hyatt", "Fox", "119674852225"));
            _doctorsList.Add(new DoctorDto(87, "Caesar", "Ramirez", "215868688058"));
            _doctorsList.Add(new DoctorDto(88, "Bruce", "Patterson", "078763257558"));
            _doctorsList.Add(new DoctorDto(89, "Clarke", "Perez", "944284733791"));
            _doctorsList.Add(new DoctorDto(90, "Kato", "Reynolds", "632085714713"));
            _doctorsList.Add(new DoctorDto(91, "Declan", "Douglas", "530373140414"));
            _doctorsList.Add(new DoctorDto(92, "Knox", "Young", "308789449416"));
            _doctorsList.Add(new DoctorDto(93, "Bradley", "Hewitt", "130462273805"));
            _doctorsList.Add(new DoctorDto(94, "Trevor", "Carney", "574584321173"));
            _doctorsList.Add(new DoctorDto(95, "Rooney", "Hudson", "476972709069"));
            _doctorsList.Add(new DoctorDto(96, "Gary", "Levy", "547046012814"));
            _doctorsList.Add(new DoctorDto(97, "Nehru", "Lee", "436290882829"));
            _doctorsList.Add(new DoctorDto(98, "Oscar", "Mcdowell", "219349457248"));
            _doctorsList.Add(new DoctorDto(99, "Raymond", "Blake", "033359376610"));
        }
    }
}