import websockets
import asyncio

async def listener():
    url = "ws://localhost:8080"
    i=0
    async with websockets.connect(url) as ws:
        print("Connected")
        msg = ""
        while(i>=0):
            
            msg = "test_"+((str)(i))

            await ws.send(msg)
            print(msg)
            i+=1
        
        
        


asyncio.get_event_loop().run_until_complete(listener())








