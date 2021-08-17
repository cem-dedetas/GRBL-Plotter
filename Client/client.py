import socket
import keyboard

HOST = '25.52.61.231'  # Standard loopback interface address (localhost)
PORT = 8910        # Port to listen on (non-privileged ports are > 1023)
with socket.socket(socket.AF_INET, socket.SOCK_STREAM) as s:
    s.connect((HOST, PORT))
    while True:  # making a loop
        # used try so that if user pressed other than the given key error will not be shown
        key='o'
        if keyboard.is_pressed('w'):  # if key 'q' is pressed 
            key='w'
        if keyboard.is_pressed('a'):  # if key 'q' is pressed 
            key='a'
        if keyboard.is_pressed('s'):  # if key 'q' is pressed 
            key='s'
        if keyboard.is_pressed('d'):  # if key 'q' is pressed 
            key='d'
        print("ready:")
        a=key
        a=a.encode('utf-8')
        s.sendall(a)
        data = s.recv(1024)
        print('Received', repr(data))
