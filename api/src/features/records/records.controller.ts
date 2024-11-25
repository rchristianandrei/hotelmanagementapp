import { Request, Response } from "express";
import db from "../../database";
import Record, { RecordModel } from "./record.model";

export class RecordsController {
  // #region Create / Update
  static async Save(req: Request, res: Response) {
    let { roomID, checkIn } = req.body;
    let checkOut = new Date();
    if (!roomID || !checkIn) {
      res.status(400).send("Invalid Parameters");
      return;
    }

    let record = new Record({
      RoomID: roomID,
      CheckIn: checkIn,
      CheckOut: checkOut,
    });

    try {
      await record.save();

      res
        .status(201)
        .json({ message: "Record created successfully", record: record });
    } catch (err) {
      console.error("Error saving record:", err);
      res.status(500).send("Error saving record");
    }
  }
  // #endregion

  // #region Read
  static async Get1000(req: Request, res: Response) {
    try {
      let records = await Record.find();

      for (let i = 0; i < records.length; i++) {
        let record: RecordModel = records[i];
        record.CheckIn.setHours(record.CheckIn.getHours() + 8);
        record.CheckOut.setHours(record.CheckOut.getHours() + 8);
      }

      res.status(200).json(records);
    } catch (err) {
      console.error("Error fetching records:", err);
      res.status(500).json({ message: "Failed to retrieve records." });
    }
  }
  // #endregion
}
