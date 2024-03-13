import { Bowler } from '../types/Bowler';
import { useEffect, useState } from 'react';

function BowlingList() {
  const [bowlerData, setBowlerData] = useState<Bowler[]>([]);

  useEffect(() => {
    const fetchBowlingData = async () => {
      const rsp = await fetch('http://localhost:5131/Bowling');
      const f = await rsp.json();
      setBowlerData(f);
    };
    fetchBowlingData();
  }, []);

  // Filter the bowler data for team names "Marlins" or "Sharks"
  const filteredBowlerData = bowlerData.filter(
    (f) => f.teamName === 'Marlins' || f.teamName === 'Sharks',
  );

  return (
    <>
      <div className="row">
        <h4 className="text-center">Bowlers</h4>
      </div>
      <table className="table table-bordered">
        <thead>
          <tr>
            <th>First Name</th>
            <th>Middle Initial</th>
            <th>Last Name</th>
            <th>Team Name</th>
            <th>Address</th>
            <th>City</th>
            <th>State</th>
            <th>Zip</th>
            <th>Phone Number</th>
          </tr>
        </thead>
        <tbody>
          {filteredBowlerData.map((f) => (
            <tr key={f.id}>
              <td>{f.firstName}</td>
              <td>{f.middleInitial}</td>
              <td>{f.lastName}</td>
              <td>{f.teamName}</td>
              <td>{f.address}</td>
              <td>{f.city}</td>
              <td>{f.state}</td>
              <td>{f.zip}</td>
              <td>{f.phoneNumber}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </>
  );
}

export default BowlingList;
