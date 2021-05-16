namespace UnitTests.FakeRepositories
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using DoctorsApplicationMicroservice.Web.Application.Dtos;

    public class TestPatientRepository
    {
        private List<PatientDto> _patientsList { get; set; }

        public TestPatientRepository()
        {
            _patientsList = new List<PatientDto>();
            init();
        }
        
        public Task<IEnumerable<PatientDto>> GetPatientsAsync()
        {
            return Task.FromResult(_patientsList as IEnumerable<PatientDto>);
        }

        private void init()
        {
            _patientsList.Add( new PatientDto(0,"Blake","Snider","329434271053"));
            _patientsList.Add( new PatientDto(1,"Scott","Dodson","214590910547"));
            _patientsList.Add( new PatientDto(2,"Blake","Moon","288556619314"));
            _patientsList.Add( new PatientDto(3,"Brady","Cruz","994941127781"));
            _patientsList.Add( new PatientDto(4,"Jermaine","Golden","466367759313"));
            _patientsList.Add( new PatientDto(5,"Lionel","Nieves","884261765830"));
            _patientsList.Add( new PatientDto(6,"Zeph","Stein","171163674016"));
            _patientsList.Add( new PatientDto(7,"Calvin","Mckay","930114545964"));
            _patientsList.Add( new PatientDto(8,"Neville","Lucas","836796200611"));
            _patientsList.Add( new PatientDto(9,"Basil","Fuentes","441770064887"));
            _patientsList.Add( new PatientDto(10,"Tobias","Cline","476360128689"));
            _patientsList.Add( new PatientDto(11,"Drew","Davidson","769513971829"));
            _patientsList.Add( new PatientDto(12,"Ray","Taylor","813360624654"));
            _patientsList.Add( new PatientDto(13,"Marvin","Stephenson","169679157513"));
            _patientsList.Add( new PatientDto(14,"Steel","Reid","498923219355"));
            _patientsList.Add( new PatientDto(15,"Armando","Lloyd","475591933859"));
            _patientsList.Add( new PatientDto(16,"Sawyer","Kirby","452051425386"));
            _patientsList.Add( new PatientDto(17,"Howard","Clay","143405345302"));
            _patientsList.Add( new PatientDto(18,"Cyrus","Horton","992447219526"));
            _patientsList.Add( new PatientDto(19,"Keith","Vance","311829057668"));
            _patientsList.Add( new PatientDto(20,"Colton","Browning","079522135958"));
            _patientsList.Add( new PatientDto(21,"Isaiah","Vinson","526409031366"));
            _patientsList.Add( new PatientDto(22,"Flynn","Roth","158218571196"));
            _patientsList.Add( new PatientDto(23,"Zahir","Francis","605316574177"));
            _patientsList.Add( new PatientDto(24,"Leonard","Clark","196756183134"));
            _patientsList.Add( new PatientDto(25,"Jarrod","Gay","865433518535"));
            _patientsList.Add( new PatientDto(26,"Nathan","Deleon","884180925850"));
            _patientsList.Add( new PatientDto(27,"Chancellor","Beard","006130842869"));
            _patientsList.Add( new PatientDto(28,"Rahim","Odom","701818708728"));
            _patientsList.Add( new PatientDto(29,"Bevis","Knapp","666101371849"));
            _patientsList.Add( new PatientDto(30,"Hasad","Herman","607618165475"));
            _patientsList.Add( new PatientDto(31,"Brady","Maynard","326680486930"));
            _patientsList.Add( new PatientDto(32,"Castor","Goodwin","833974120612"));
            _patientsList.Add( new PatientDto(33,"Gray","Case","222379655859"));
            _patientsList.Add( new PatientDto(34,"Colt","Parks","842508821344"));
            _patientsList.Add( new PatientDto(35,"Walter","Raymond","859030995270"));
            _patientsList.Add( new PatientDto(36,"Calvin","Goodman","947112570295"));
            _patientsList.Add( new PatientDto(37,"Gil","Pacheco","944498190371"));
            _patientsList.Add( new PatientDto(38,"Lucian","Gutierrez","982123635344"));
            _patientsList.Add( new PatientDto(39,"Jordan","Wheeler","843123210273"));
            _patientsList.Add( new PatientDto(40,"Kasimir","Ballard","896357504254"));
            _patientsList.Add( new PatientDto(41,"Jin","Rich","126995223072"));
            _patientsList.Add( new PatientDto(42,"Phelan","Goodwin","956420431795"));
            _patientsList.Add( new PatientDto(43,"Hasad","Baldwin","608763678451"));
            _patientsList.Add( new PatientDto(44,"Drake","Mullins","909207736881"));
            _patientsList.Add( new PatientDto(45,"Jerome","Weiss","619365807473"));
            _patientsList.Add( new PatientDto(46,"Todd","Sears","366897362406"));
            _patientsList.Add( new PatientDto(47,"Kevin","Mckee","980556741598"));
            _patientsList.Add( new PatientDto(48,"Gareth","Beasley","017998825174"));
            _patientsList.Add( new PatientDto(49,"Denton","Cline","474189588627"));
            _patientsList.Add( new PatientDto(50,"Theodore","Reilly","938942243721"));
            _patientsList.Add( new PatientDto(51,"Clark","Mcdowell","012795269489"));
            _patientsList.Add( new PatientDto(52,"Dale","Bell","182406083661"));
            _patientsList.Add( new PatientDto(53,"Noble","Andrews","581934258823"));
            _patientsList.Add( new PatientDto(54,"Holmes","Lane","045467044693"));
            _patientsList.Add( new PatientDto(55,"Brett","Moss","151372481755"));
            _patientsList.Add( new PatientDto(56,"Aristotle","Sherman","095267055299"));
            _patientsList.Add( new PatientDto(57,"Samson","Ramos","655816539565"));
            _patientsList.Add( new PatientDto(58,"Kermit","Cantrell","688239366269"));
            _patientsList.Add( new PatientDto(59,"Grady","Alexander","563967420134"));
            _patientsList.Add( new PatientDto(60,"Daquan","Cardenas","357476741560"));
            _patientsList.Add( new PatientDto(61,"Rafael","Simon","494885487487"));
            _patientsList.Add( new PatientDto(62,"Basil","Carpenter","978410643041"));
            _patientsList.Add( new PatientDto(63,"Benedict","Farmer","594587552590"));
            _patientsList.Add( new PatientDto(64,"Mohammad","Tucker","853552564559"));
            _patientsList.Add( new PatientDto(65,"Quinlan","Stevenson","963453607529"));
            _patientsList.Add( new PatientDto(66,"Leo","Harmon","176382197195"));
            _patientsList.Add( new PatientDto(67,"Slade","Pacheco","086796083527"));
            _patientsList.Add( new PatientDto(68,"Macon","Monroe","122135566101"));
            _patientsList.Add( new PatientDto(69,"Victor","Cunningham","216498596958"));
            _patientsList.Add( new PatientDto(70,"Lucian","Stanley","495619650674"));
            _patientsList.Add( new PatientDto(71,"Hamilton","Frederick","559124421783"));
            _patientsList.Add( new PatientDto(72,"Chancellor","Mann","382716951205"));
            _patientsList.Add( new PatientDto(73,"Adrian","Love","530878579600"));
            _patientsList.Add( new PatientDto(74,"Lee","Burton","295320974947"));
            _patientsList.Add( new PatientDto(75,"Hunter","Daniel","078601452120"));
            _patientsList.Add( new PatientDto(76,"Samson","Spence","179068949251"));
            _patientsList.Add( new PatientDto(77,"Slade","Mack","601715659066"));
            _patientsList.Add( new PatientDto(78,"Noah","Cohen","945938699117"));
            _patientsList.Add( new PatientDto(79,"Colt","Baxter","021189939026"));
            _patientsList.Add( new PatientDto(80,"Bert","Hahn","795919803198"));
            _patientsList.Add( new PatientDto(81,"Rajah","Mckee","906374582165"));
            _patientsList.Add( new PatientDto(82,"Brenden","Brennan","244556561709"));
            _patientsList.Add( new PatientDto(83,"Otto","Decker","144766867704"));
            _patientsList.Add( new PatientDto(84,"Dieter","Hall","530863966666"));
            _patientsList.Add( new PatientDto(85,"Quentin","Klein","701206404605"));
            _patientsList.Add( new PatientDto(86,"Kermit","Silva","492566155443"));
            _patientsList.Add( new PatientDto(87,"James","Sherman","273009591783"));
            _patientsList.Add( new PatientDto(88,"Caleb","Gaines","907803149753"));
            _patientsList.Add( new PatientDto(89,"Kermit","Arnold","677001196094"));
            _patientsList.Add( new PatientDto(90,"Dale","Fowler","502560666677"));
            _patientsList.Add( new PatientDto(91,"Lucas","Coleman","752557256663"));
            _patientsList.Add( new PatientDto(92,"Addison","Evans","511013593956"));
            _patientsList.Add( new PatientDto(93,"Chandler","Shields","209504919647"));
            _patientsList.Add( new PatientDto(94,"Wylie","Ruiz","294734171537"));
            _patientsList.Add( new PatientDto(95,"Hashim","Oneill","589152861291"));
            _patientsList.Add( new PatientDto(96,"Nasim","Austin","431180963486"));
            _patientsList.Add( new PatientDto(97,"Kareem","Williamson","709341995613"));
            _patientsList.Add( new PatientDto(98,"Elvis","Atkins","482592288553"));
            _patientsList.Add( new PatientDto(99,"Henry","Wolfe","113827262859"));
        }
    }
}