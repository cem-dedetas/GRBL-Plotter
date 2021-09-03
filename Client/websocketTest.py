import websockets
import asyncio
import cv2
import numpy as np

async def listener():
    print("hello")
    msg = "hi!!"
    url = "ws://127.0.0.1:8090"
    async with websockets.connect(url) as ws:
        print("Connected")
            
        await ws.send(msg)
        print(msg)
        
asyncio.get_event_loop().run_until_complete(listener())