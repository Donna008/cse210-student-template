public class Resume{
    public string _name;
    //  about below has two ways to finish it
    // public List<Job> _jobs= new List<Job();
    public List<Job> _jobs= new List<Job>();

    public void Dispaly(){
        //  here the job like for i in python for loop, it just a valuable name
        foreach (Job job in _jobs){
            job.Dispaly();
        }
    }

}