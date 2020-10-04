class Array{
    void learn1DArray(){
        byte[] array1=new byte[10];//syt\ntax to iniitalixe byte
        array1[0]=34;
        array1[2]=67;
       //to initialze data type in arrays;
        float[] array2=new float[]{1.3f,1.8f,3.6f,55.5f};
        int x=array2.Length;
        char[] array3={'a','b','c'};
        float[]subArray1=array2[1..3];
    }
    void learnMulDArray(){
        //2darray
        int[,]numbers=new int[3,5];//row and coloumn
        numbers[0,0]=342;
        numbers[3,4]=-37654;
        decimal[,]numbers1={{0.1m,3.8m},{5.7m,6.8m}};//initialixe of decimal data type//arratt pf dame sixw

        

    }
    void learnJaggedArray(){
        short[][] numbers2=new short[3][];//cant accept column size. 
        numbers2[0]=new short[]{3,5,6};
        numbers2[1]=new short[]{3,5,7};
    }
    
}