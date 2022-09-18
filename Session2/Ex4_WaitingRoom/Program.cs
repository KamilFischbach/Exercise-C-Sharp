// See https://aka.ms/new-console-template for more information

using Ex4_WaitingRoom;

WaitingRoom wr = new WaitingRoom();

Patient p1 = new Patient(wr);
Patient p2 = new Patient(wr);
Patient p3 = new Patient(wr);
Patient p4 = new Patient(wr);
Patient p5 = new Patient(wr);

wr.RunWaitingRoom();