import React, { useState } from 'react'
import Nav from '../../components/Nav';
import { useNavigate } from 'react-router-dom';
import Api from '../../api/endpoints'
import sampleTree from '../../sampleTree.json';

const CreateAdventure = () => {
    const [loading,setLoading] = useState(false);
    const [tree,setTree] = useState(JSON.stringify(sampleTree, undefined, 2));
    const [error, setError] = useState("");
    const navigate = useNavigate();
    const handleTreeChange = event => {
        setTree(event.target.value);
      };
    const handleAdventureCreation = async () =>
    {
        setLoading(true);
        setError("");  
        const userResponse = await createUser();
        if(userResponse)
        {
            const userId = window.localStorage.getItem('userId');
            //var postTree = JSON.stringify(tree);
            var mainTree = {
                name: "Adventure",
                creatorId: userId,
                questions: JSON.parse(tree)
            }
            var adventureReponse=await Api.createAdventure(mainTree);
            if(!adventureReponse.error)
            {
                window.localStorage.setItem('adventureId',adventureReponse.id);
                navigate('take/adventure/:'+adventureReponse.id);
            }else
            {
                setError(adventureReponse.error);  
            }
        }
        setLoading(false);
    }
    const createUser = async () =>
    {
        const userId = window.localStorage.getItem('userId');
        if(!userId)
        {
            const userResponse=await Api.createUser({ name: '' });
            if(!userResponse.error)
            {
                const id = userResponse.id;
                window.localStorage.setItem('userId',id);
                return true;
            }
            else
            {
                setError(userResponse.error);  
                return false;  
            }            
        }
        return true;
    }
    
    const handleClearStorage = ()=> {
        window.localStorage.removeItem('adventureId');
        window.localStorage.removeItem('userId');
        window.localStorage.removeItem('userAdventureId');
    }
  return (
    <>
    <Nav />
        <div>
            <textarea onChange={handleTreeChange} value={tree}></textarea>
            <p value={error}></p>
            <button onClick={handleAdventureCreation} disabled={loading}>Create Adventure</button>
            <button onClick={handleClearStorage} disabled={loading}>Clear Data</button>
        </div>
    </>
  )
}

export default CreateAdventure