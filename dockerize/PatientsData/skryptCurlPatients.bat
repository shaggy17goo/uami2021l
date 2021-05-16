echo Lista pacjentow:
curl -X GET "http://localhost:8081/listPatients" -H  "accept: text/plain"
echo Dane pacjenta wg id:
curl -X GET "http://localhost:8081/getPatientById?patientId=1" -H  "accept: text/plain"
echo Dane pacjenta wg PESEL:
curl -X GET "http://localhost:8081/getPatientByPESEL?PESEL=70234667269" -H  "accept: text/plain"
echo Dodanie pacjenta
curl -X POST "http://localhost:8081/addPatient" -H  "accept: text/plain" -H  "Content-Type: application/json" -d "{\"pesel\":\"temp\",\"name\":\"string\",\"surname\":\"string\",\"sex\":\"string\",\"birthDate\":\"2021-04-18T19:57:10.852Z\",\"city\":\"string\",\"street\":\"string\",\"houseNr\":\"string\"}" >> temp.txt
set /p result=<temp.txt
echo Dodane id = %result%
del "%~dp0\temp.txt" /s /f /q
echo Usunieto pacjenta
curl -X POST "http://localhost:8081/deletePatient" -H  "accept: text/plain" -H  "Content-Type: application/json" -d "{\"patientId\":%result%,\"pesel\":\"string\"}"
pause