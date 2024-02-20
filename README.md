# Spring Cleaning
Hide parts from the OAB parts picker. Useful for modders who want to deprecate old parts or for players that need a cleaner OAB experience.

## Planned features
- [ ] Add a "Hide Part" button to each part in the OAB Parts Picker.
- [ ] Save user-hidden parts to the save file.
- [ ] In-game UI accessible in the OAB to un-hide parts.

## Usage

### For modders
You can hide a part using [Patch Manager](https://github.com/KSP2Community/PatchManager) by creating a new patch that looks like this:
```scss
@new(spring_cleaning, my_part_id_cleanup)
:json {
  PartId: my_part_id;
  Hidden: true;
  Toggleable: false;
}
```
With:
- `PartId`: your part's Id.
- `Hidden`: should the part be hidden from the OAB Parts Picker.
- `Toggleable`: should the players be able to un-hide the part.

### For players