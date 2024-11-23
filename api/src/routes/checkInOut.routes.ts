import { Router } from "express";
import { CheckInOutController } from "../controllers/checkInOut.controller";

const router: Router = Router();

// #region Create / Update
router.post("/:id/:hour", CheckInOutController.Save);
// #endregion

// #region Read
router.get("/", CheckInOutController.Get1000);
// #endregion

// #region Delete
router.delete("/:id", CheckInOutController.Delete);
// #endregion

export default router;
