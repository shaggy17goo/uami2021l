echo Lista wizyt:
curl -X GET "https://localhost:44392/listAppointments" -H  "accept: text/plain"
echo Lista wizyt danego doktora:
curl -X GET "https://localhost:44392/getAppointmentByDoctorId?doctorId=1" -H  "accept: text/plain
echo Lista wizyt pacjenta:
curl -X GET "https://localhost:44392/getAppointmentByPatientId?patientId=1" -H  "accept: text/plain"
echo Dane wizyty wg id:
curl -X GET "https://localhost:44392/getAppointmentById?appointmentId=1" -H  "accept: text/plain"
echo Dodaj wizyte:
curl -X POST "https://localhost:44392/addAppointment" -H  "accept: text/plain" -H  "Content-Type: application/json" -d "{\"doctorId\":1,\"patientId\":1,\"dateOfAppointment\":\"2021-04-18T21:42:21.864Z\",\"description\":\"string\"}" >>temp.txt
set /p result=<temp.txt
echo Dodane id = %result%
del "%~dp0\temp.txt" /s /f /q
echo Usun wizyte:
curl -X POST "https://localhost:44392/deleteAppointment" -H  "accept: text/plain" -H  "Content-Type: application/json" -d "{\"appointmentId\":%result%}"
pause