import React, {useState,useEffect} from 'react'
import { Link } from 'react-router-dom';


const Nav = () => {
    const [adventureId, setAdventureId] = useState("");
    useEffect(() => {
        const getAdventureId = window.localStorage.getItem('adventureId');
        setAdventureId(getAdventureId);
        console.log("Adventure Id "+ getAdventureId);
      },[adventureId])
      
  return (
    <div className='content'>
        
              <span>
                <Link to="/">Create an Adventure</Link>
                
              </span>
              <span>
                <Link to={"/take/adventure/:"+adventureId}>Take an Adventure</Link>
              </span>
              <span>
                <Link to={"/my/adventure/:"+adventureId}>My Adventure</Link>
              </span>
            
    </div>
  )
}

export default Nav