namespace UnitTests.FakeRepositories
{
	using System.Collections.Generic;
	using System.Threading.Tasks;
	using DoctorsApplicationMicroservice.Web.Application.Dtos;
	using NUnit.Framework;

	public class TestAppointmentRepository
    {
	    
	    private List<AppointmentDto> _appointmentsList { get; set; }

	    public TestAppointmentRepository()
	    {
		    _appointmentsList = new List<AppointmentDto>();
		    init();
		    
	    }

	    public Task<IEnumerable<AppointmentDto>> GetAppointmentsAsync()
	    {
		    return Task.FromResult(_appointmentsList as IEnumerable<AppointmentDto>);
	    }

	    private void init()
	    { 
		    _appointmentsList.Add( new AppointmentDto(0,24,50,"non, vestibulum nec, euismod in, dolor. Fusce feugiat. Lorem ipsum"));
			_appointmentsList.Add( new AppointmentDto(1,94,72,"arcu. Vestibulum ut eros non enim commodo hendrerit. Donec porttitor"));
			_appointmentsList.Add( new AppointmentDto(2,72,23,"venenatis lacus. Etiam bibendum fermentum metus. Aenean sed pede nec"));
			_appointmentsList.Add( new AppointmentDto(3,45,77,"Cras dolor dolor, tempus non, lacinia at, iaculis quis, pede."));
			_appointmentsList.Add( new AppointmentDto(4,27,74,"luctus felis purus ac tellus. Suspendisse sed dolor. Fusce mi"));
			_appointmentsList.Add( new AppointmentDto(5,12,38,"felis. Donec tempor, est ac mattis semper, dui lectus rutrum"));
			_appointmentsList.Add( new AppointmentDto(6,48,81,"neque sed dictum eleifend, nunc risus varius orci, in consequat"));
			_appointmentsList.Add( new AppointmentDto(7,19,10,"vehicula. Pellentesque tincidunt tempus risus. Donec egestas. Duis ac arcu."));
			_appointmentsList.Add( new AppointmentDto(8,49,2,"faucibus id, libero. Donec consectetuer mauris id sapien. Cras dolor"));
			_appointmentsList.Add( new AppointmentDto(9,50,73,"cursus et, eros. Proin ultrices. Duis volutpat nunc sit amet"));
			_appointmentsList.Add( new AppointmentDto(10,96,97,"mauris ipsum porta elit, a feugiat tellus lorem eu metus."));
			_appointmentsList.Add( new AppointmentDto(11,26,60,"Donec feugiat metus sit amet ante. Vivamus non lorem vitae"));
			_appointmentsList.Add( new AppointmentDto(12,11,48,"dolor. Fusce feugiat. Lorem ipsum dolor sit amet, consectetuer adipiscing"));
			_appointmentsList.Add( new AppointmentDto(13,44,60,"Praesent luctus. Curabitur egestas nunc sed libero. Proin sed turpis"));
			_appointmentsList.Add( new AppointmentDto(14,87,32,"mauris a nunc. In at pede. Cras vulputate velit eu"));
			_appointmentsList.Add( new AppointmentDto(15,98,45,"dictum ultricies ligula. Nullam enim. Sed nulla ante, iaculis nec,"));
			_appointmentsList.Add( new AppointmentDto(16,2,21,"feugiat nec, diam. Duis mi enim, condimentum eget, volutpat ornare,"));
			_appointmentsList.Add( new AppointmentDto(17,40,86,"Quisque nonummy ipsum non arcu. Vivamus sit amet risus. Donec"));
			_appointmentsList.Add( new AppointmentDto(18,65,61,"non justo. Proin non massa non ante bibendum ullamcorper. Duis"));
			_appointmentsList.Add( new AppointmentDto(19,52,67,"nec, leo. Morbi neque tellus, imperdiet non, vestibulum nec, euismod"));
			_appointmentsList.Add( new AppointmentDto(20,40,14,"et, eros. Proin ultrices. Duis volutpat nunc sit amet metus."));
			_appointmentsList.Add( new AppointmentDto(21,27,32,"rutrum magna. Cras convallis convallis dolor. Quisque tincidunt pede ac"));
			_appointmentsList.Add( new AppointmentDto(22,96,45,"felis. Nulla tempor augue ac ipsum. Phasellus vitae mauris sit"));
			_appointmentsList.Add( new AppointmentDto(23,54,86,"auctor non, feugiat nec, diam. Duis mi enim, condimentum eget,"));
			_appointmentsList.Add( new AppointmentDto(24,88,6,"In at pede. Cras vulputate velit eu sem. Pellentesque ut"));
			_appointmentsList.Add( new AppointmentDto(25,20,54,"tellus id nunc interdum feugiat. Sed nec metus facilisis lorem"));
			_appointmentsList.Add( new AppointmentDto(26,12,87,"urna suscipit nonummy. Fusce fermentum fermentum arcu. Vestibulum ante ipsum"));
			_appointmentsList.Add( new AppointmentDto(27,20,6,"imperdiet non, vestibulum nec, euismod in, dolor. Fusce feugiat. Lorem"));
			_appointmentsList.Add( new AppointmentDto(28,39,16,"dictum mi, ac mattis velit justo nec ante. Maecenas mi"));
			_appointmentsList.Add( new AppointmentDto(29,9,12,"fermentum risus, at fringilla purus mauris a nunc. In at"));
			_appointmentsList.Add( new AppointmentDto(30,98,54,"justo eu arcu. Morbi sit amet massa. Quisque porttitor eros"));
			_appointmentsList.Add( new AppointmentDto(31,79,90,"iaculis aliquet diam. Sed diam lorem, auctor quis, tristique ac,"));
			_appointmentsList.Add( new AppointmentDto(32,48,43,"aliquam iaculis, lacus pede sagittis augue, eu tempor erat neque"));
			_appointmentsList.Add( new AppointmentDto(33,1,41,"arcu eu odio tristique pharetra. Quisque ac libero nec ligula"));
			_appointmentsList.Add( new AppointmentDto(34,25,59,"tincidunt orci quis lectus. Nullam suscipit, est ac facilisis facilisis,"));
			_appointmentsList.Add( new AppointmentDto(35,74,67,"nunc. Quisque ornare tortor at risus. Nunc ac sem ut"));
			_appointmentsList.Add( new AppointmentDto(36,21,49,"gravida molestie arcu. Sed eu nibh vulputate mauris sagittis placerat."));
			_appointmentsList.Add( new AppointmentDto(37,67,82,"Ut semper pretium neque. Morbi quis urna. Nunc quis arcu"));
			_appointmentsList.Add( new AppointmentDto(38,68,67,"arcu. Sed eu nibh vulputate mauris sagittis placerat. Cras dictum"));
			_appointmentsList.Add( new AppointmentDto(39,18,3,"lobortis tellus justo sit amet nulla. Donec non justo. Proin"));
			_appointmentsList.Add( new AppointmentDto(40,10,83,"tincidunt tempus risus. Donec egestas. Duis ac arcu. Nunc mauris."));
			_appointmentsList.Add( new AppointmentDto(41,99,17,"ridiculus mus. Proin vel nisl. Quisque fringilla euismod enim. Etiam"));
			_appointmentsList.Add( new AppointmentDto(42,24,82,"Aliquam vulputate ullamcorper magna. Sed eu eros. Nam consequat dolor"));
			_appointmentsList.Add( new AppointmentDto(43,34,46,"orci. Ut semper pretium neque. Morbi quis urna. Nunc quis"));
			_appointmentsList.Add( new AppointmentDto(44,42,81,"est tempor bibendum. Donec felis orci, adipiscing non, luctus sit"));
			_appointmentsList.Add( new AppointmentDto(45,70,50,"odio semper cursus. Integer mollis. Integer tincidunt aliquam arcu. Aliquam"));
			_appointmentsList.Add( new AppointmentDto(46,83,24,"vitae purus gravida sagittis. Duis gravida. Praesent eu nulla at"));
			_appointmentsList.Add( new AppointmentDto(47,79,97,"vulputate velit eu sem. Pellentesque ut ipsum ac mi eleifend"));
			_appointmentsList.Add( new AppointmentDto(48,55,9,"nunc interdum feugiat. Sed nec metus facilisis lorem tristique aliquet."));
			_appointmentsList.Add( new AppointmentDto(49,63,16,"Cras sed leo. Cras vehicula aliquet libero. Integer in magna."));
			_appointmentsList.Add( new AppointmentDto(50,41,32,"Nunc mauris elit, dictum eu, eleifend nec, malesuada ut, sem."));
			_appointmentsList.Add( new AppointmentDto(51,35,12,"quis accumsan convallis, ante lectus convallis est, vitae sodales nisi"));
			_appointmentsList.Add( new AppointmentDto(52,56,79,"in, tempus eu, ligula. Aenean euismod mauris eu elit. Nulla"));
			_appointmentsList.Add( new AppointmentDto(53,7,9,"amet, dapibus id, blandit at, nisi. Cum sociis natoque penatibus"));
			_appointmentsList.Add( new AppointmentDto(54,52,23,"sagittis semper. Nam tempor diam dictum sapien. Aenean massa. Integer"));
			_appointmentsList.Add( new AppointmentDto(55,60,8,"purus. Nullam scelerisque neque sed sem egestas blandit. Nam nulla"));
			_appointmentsList.Add( new AppointmentDto(56,69,97,"pretium neque. Morbi quis urna. Nunc quis arcu vel quam"));
			_appointmentsList.Add( new AppointmentDto(57,72,59,"gravida non, sollicitudin a, malesuada id, erat. Etiam vestibulum massa"));
			_appointmentsList.Add( new AppointmentDto(58,19,73,"Nullam suscipit, est ac facilisis facilisis, magna tellus faucibus leo,"));
			_appointmentsList.Add( new AppointmentDto(59,91,79,"eget ipsum. Suspendisse sagittis. Nullam vitae diam. Proin dolor. Nulla"));
			_appointmentsList.Add( new AppointmentDto(60,25,35,"ut erat. Sed nunc est, mollis non, cursus non, egestas"));
			_appointmentsList.Add( new AppointmentDto(61,38,6,"erat neque non quam. Pellentesque habitant morbi tristique senectus et"));
			_appointmentsList.Add( new AppointmentDto(62,79,67,"sapien molestie orci tincidunt adipiscing. Mauris molestie pharetra nibh. Aliquam"));
			_appointmentsList.Add( new AppointmentDto(63,73,15,"ut, sem. Nulla interdum. Curabitur dictum. Phasellus in felis. Nulla"));
			_appointmentsList.Add( new AppointmentDto(64,69,97,"libero mauris, aliquam eu, accumsan sed, facilisis vitae, orci. Phasellus"));
			_appointmentsList.Add( new AppointmentDto(65,57,48,"ac tellus. Suspendisse sed dolor. Fusce mi lorem, vehicula et,"));
			_appointmentsList.Add( new AppointmentDto(66,75,91,"ut quam vel sapien imperdiet ornare. In faucibus. Morbi vehicula."));
			_appointmentsList.Add( new AppointmentDto(67,1,11,"eu augue porttitor interdum. Sed auctor odio a purus. Duis"));
			_appointmentsList.Add( new AppointmentDto(68,11,72,"mollis dui, in sodales elit erat vitae risus. Duis a"));
			_appointmentsList.Add( new AppointmentDto(69,63,48,"eleifend egestas. Sed pharetra, felis eget varius ultrices, mauris ipsum"));
			_appointmentsList.Add( new AppointmentDto(70,95,11,"Nulla facilisi. Sed neque. Sed eget lacus. Mauris non dui"));
			_appointmentsList.Add( new AppointmentDto(71,62,1,"metus facilisis lorem tristique aliquet. Phasellus fermentum convallis ligula. Donec"));
			_appointmentsList.Add( new AppointmentDto(72,32,33,"Cras vulputate velit eu sem. Pellentesque ut ipsum ac mi"));
			_appointmentsList.Add( new AppointmentDto(73,51,30,"Cras sed leo. Cras vehicula aliquet libero. Integer in magna."));
			_appointmentsList.Add( new AppointmentDto(74,27,36,"massa lobortis ultrices. Vivamus rhoncus. Donec est. Nunc ullamcorper, velit"));
			_appointmentsList.Add( new AppointmentDto(75,98,97,"mi pede, nonummy ut, molestie in, tempus eu, ligula. Aenean"));
			_appointmentsList.Add( new AppointmentDto(76,78,57,"arcu. Sed eu nibh vulputate mauris sagittis placerat. Cras dictum"));
			_appointmentsList.Add( new AppointmentDto(77,79,77,"commodo tincidunt nibh. Phasellus nulla. Integer vulputate, risus a ultricies"));
			_appointmentsList.Add( new AppointmentDto(78,8,67,"dui. Cras pellentesque. Sed dictum. Proin eget odio. Aliquam vulputate"));
			_appointmentsList.Add( new AppointmentDto(79,70,29,"molestie dapibus ligula. Aliquam erat volutpat. Nulla dignissim. Maecenas ornare"));
			_appointmentsList.Add( new AppointmentDto(80,91,58,"Phasellus fermentum convallis ligula. Donec luctus aliquet odio. Etiam ligula"));
			_appointmentsList.Add( new AppointmentDto(81,58,39,"ante. Vivamus non lorem vitae odio sagittis semper. Nam tempor"));
			_appointmentsList.Add( new AppointmentDto(82,82,49,"Donec nibh enim, gravida sit amet, dapibus id, blandit at,"));
			_appointmentsList.Add( new AppointmentDto(83,94,95,"ornare, elit elit fermentum risus, at fringilla purus mauris a"));
			_appointmentsList.Add( new AppointmentDto(84,24,40,"et ultrices posuere cubilia Curae; Donec tincidunt. Donec vitae erat"));
			_appointmentsList.Add( new AppointmentDto(85,90,36,"Donec non justo. Proin non massa non ante bibendum ullamcorper."));
			_appointmentsList.Add( new AppointmentDto(86,88,23,"Proin vel nisl. Quisque fringilla euismod enim. Etiam gravida molestie"));
			_appointmentsList.Add( new AppointmentDto(87,95,62,"non leo. Vivamus nibh dolor, nonummy ac, feugiat non, lobortis"));
			_appointmentsList.Add( new AppointmentDto(88,71,56,"vitae, sodales at, velit. Pellentesque ultricies dignissim lacus. Aliquam rutrum"));
			_appointmentsList.Add( new AppointmentDto(89,19,92,"Morbi accumsan laoreet ipsum. Curabitur consequat, lectus sit amet luctus"));
			_appointmentsList.Add( new AppointmentDto(90,85,35,"Donec at arcu. Vestibulum ante ipsum primis in faucibus orci"));
			_appointmentsList.Add( new AppointmentDto(91,11,77,"adipiscing, enim mi tempor lorem, eget mollis lectus pede et"));
			_appointmentsList.Add( new AppointmentDto(92,10,89,"massa. Mauris vestibulum, neque sed dictum eleifend, nunc risus varius"));
			_appointmentsList.Add( new AppointmentDto(93,77,33,"Aliquam erat volutpat. Nulla facilisis. Suspendisse commodo tincidunt nibh. Phasellus"));
			_appointmentsList.Add( new AppointmentDto(94,20,83,"vestibulum, neque sed dictum eleifend, nunc risus varius orci, in"));
			_appointmentsList.Add( new AppointmentDto(95,2,99,"taciti sociosqu ad litora torquent per conubia nostra, per inceptos"));
			_appointmentsList.Add( new AppointmentDto(96,55,31,"lorem, sit amet ultricies sem magna nec quam. Curabitur vel"));
			_appointmentsList.Add( new AppointmentDto(97,57,83,"Cum sociis natoque penatibus et magnis dis parturient montes, nascetur"));
			_appointmentsList.Add( new AppointmentDto(98,30,3,"Cras interdum. Nunc sollicitudin commodo ipsum. Suspendisse non leo. Vivamus"));
			_appointmentsList.Add( new AppointmentDto(99,2,92,"sagittis felis. Donec tempor, est ac mattis semper, dui lectus"));

	    }

    }
}