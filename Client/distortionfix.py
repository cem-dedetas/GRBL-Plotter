import cv2
import numpy as np


def fixer(file0,file1):
    
    path = r'C:\\Users\\Liquidsnake\\Documents\\GitHub\\GRBL-Plotter\\Client\\distort.jpg'
    path2 = r'C:\\Users\\Liquidsnake\\Documents\\GitHub\\GRBL-Plotter\\Client\\distort1.jpg'

    
    img=cv2.imread(path)
    img1=cv2.imread(path2)
    width=1200
    height=1360
    arr=np.float32([[670,520],[1520,450],[120,1057],[1900,1059]])
    transformed=np.float32([[0,0],[width,0],[0,height],[width,height]])



    """
    print(arr)
    for i in range(len(arr)):
        cv2.circle(img,((int)(arr[i][0]),(int)(arr[i][1])),5,(0,0,255),cv2.FILLED)
    """
    matrix=cv2.getPerspectiveTransform(arr,transformed)
    output=cv2.warpPerspective(img,matrix,(width,height))
    cv2.imwrite('distest0.jpeg', output)
    
    matrix=cv2.getPerspectiveTransform(arr,transformed)
    output1=cv2.warpPerspective(img1,matrix,(width,height))
    cv2.imwrite('distest1.jpeg', output1)

    
    #cv2.imshow("original image",img)
    #cv2.imshow("transformed image",output)
    #cv2.destroyAllWindows()




if __name__ == "__main__":
    fixer("distort","distort1")
