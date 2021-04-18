echo Wizyty doktora wg jego id:
curl -X GET "https://localhost:44394/appointmentsByDoctorId?doctorId=1" -H  "accept: text/plain"
echo Wizyty doktora wg jego id i daty:
curl -X GET "https://localhost:44394/appointmentsByDoctorIdAndData?doctorId=1&data=2021-07-09" -H  "accept: text/plain"
echo Pacjenci doktora wg jego id:
curl -X GET "https://localhost:44394/patientsByDoctorId?doctorId=1" -H  "accept: text/plain"
echo Pacjent wg jego id:
curl -X GET "https://localhost:44394/patientById?patientId=1" -H  "accept: text/plain"
echo Dodaj pacjenta:
curl -X POST "https://localhost:44394/addPatient" -H  "accept: text/plain" -H  "Content-Type: application/json" -d "{\"pesel\":\"string\",\"name\":\"string\",\"surname\":\"string\",\"sex\":\"string\",\"birthDate\":\"2021-04-18T21:52:25.586Z\",\"city\":\"string\",\"street\":\"string\",\"houseNr\":\"string\"}"
echo Dodaj wizyte:
curl -X POST "https://localhost:44394/addAppointment" -H  "accept: text/plain" -H  "Content-Type: application/json" -d "{\"appointmentId\":0,\"doctorId\":1,\"patientId\":1,\"dateOfAppointment\":\"2021-04-18T21:54:11.445Z\",\"description\":\"opis\"}" >> temp.txt
set /p result=<temp.txt
echo Dodane id = %result%
del "%~dp0\temp.txt" /s /f /q
echo Usun wizyte:
curl -X POST "https://localhost:44394/deleteAppointment" -H  "accept: text/plain" -H  "Content-Type: application/json" -d "{\"appointmentId\":%result%}"
pause