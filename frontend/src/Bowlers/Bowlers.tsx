import { useEffect, useState } from 'react';
import { Bowler } from '../types/Bowler';

function BowlerList() {
  // bowlerData holds the current state value while setBowlerData is the function that allows updating the state
  const [bowlerData, setBowlerData] = useState<Bowler[]>([]);

  // this stops it from checking every moment. instead, it does a fetch if it needs to make an update.
  useEffect(() => {
    const fetchBowlerData = async () => {
      const rsp = await fetch('http://localhost:5059/bowler');
      const b = await rsp.json(); // sets bowlerData equal to b
      setBowlerData(b);
    };
    fetchBowlerData();
  }, []); // blank array to only run it once if there's nothing to grab

  return (
    <>
      <div className="row">
        <h4 className="text-center">Bowler</h4>
      </div>
      <table className="table table-bordered">
        <thead>
          <tr>
            <th>Bowler Name</th>
            <th>Team Name</th>
            <th>Address</th>
            <th>City</th>
            <th>State</th>
            <th>Zip</th>
            <th>PhoneNumber</th>
          </tr>
        </thead>
        <tbody>
          {bowlerData.map((b) => (
            <tr key={b.bowlerId}>
              <td>
                {b.bowlerFirstName} {b.bowlerMiddleInit} {b.bowlerLastName}
              </td>
              <td>{b.teamName}</td>
              <td>{b.bowlerAddress}</td>
              <td>{b.bowlerCity}</td>
              <td>{b.bowlerState}</td>
              <td>{b.bowlerZip}</td>
              <td>{b.bowlerPhoneNumber}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </>
  );
}

export default BowlerList;
