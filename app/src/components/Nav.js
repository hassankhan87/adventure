import React, {useState,useEffect} from 'react'
import { Link } from 'react-router-dom';


const Nav = () => {
    const [adventureId, setAdventureId] = useState("");
    const [userAdventureId, setuserAdventureId] = useState("");
    useEffect(() => {
        const getAdventureId = window.localStorage.getItem('adventureId');
        const getUserAdventureId = window.localStorage.getItem('userAdventureId');
        setAdventureId(getAdventureId);
        setuserAdventureId(getUserAdventureId);
      },[adventureId,userAdventureId])
      
  return (
    <div className='content'>
        
              <span>
                <Link to="/">Create an Adventure</Link>
                
              </span>
              <span>
                <Link to={"/take/adventure/:"+adventureId}>Take an Adventure</Link>
              </span>
              <span>
                <Link to={"/my/adventure/:"+userAdventureId}>My Adventure</Link>
              </span>
            
    </div>
  )
}

export default Nav