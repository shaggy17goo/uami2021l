docker build -t shaggy17goo/uaim:doctors_data ./Doctors
docker push shaggy17goo/uaim:doctors_data

docker build -t shaggy17goo/uaim:patients_data ./PatientsData
docker push shaggy17goo/uaim:patients_data

docker build -t shaggy17goo/uaim:appointments_data ./AppointmentsData
docker push shaggy17goo/uaim:appointments_data

docker build -t shaggy17goo/uaim:doctor_microservice ./DoctorsApplicationMicroservice
docker push shaggy17goo/uaim:doctor_microservice

docker build -t shaggy17goo/uaim:patient_microservice ./PatientsApplicationMicroservice
docker push shaggy17goo/uaim:patient_microservice
