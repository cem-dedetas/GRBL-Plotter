import websockets
import asyncio

async def listener():
    url = "ws://localhost:9000"
    i=0
    async with websockets.connect(url) as ws:
        print("Connected")
            
        msg = "test_"
        await ws.send(msg)
        print(msg)
        
        
        


asyncio.get_event_loop().run_until_complete(listener())








